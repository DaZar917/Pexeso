
function showFileUpload(){
    document.getElementById('fsetFileUpload').classList.remove("hiddenElm");
    document.getElementById('btShowFileUpload').classList.add("hiddenElm");
}


function cancelFileUpload(){
    document.getElementById('fsetFileUpload').classList.add("hiddenElm");
    document.getElementById('btShowFileUpload').classList.remove("hiddenElm");
}


function uploadImg(serverUrl) {

    const files = document.getElementById("flElm").files;

    if (files.length > 0) {
        const imgLinkElement = document.getElementById("imageLink");
        const fieldsetElement = document.getElementById("fsetFileUpload");
        const btShowFileUploadElement = document.getElementById("btShowFileUpload");


        imgData.append("file", files[0]);

        const postReqSettings =
            {
                method: 'POST',
                body: imgData
            };


        fetch(`${serverUrl}/fileUpload`, postReqSettings)
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    return Promise.reject(new Error(`Server answered with ${response.status}: ${response.statusText}.`));
                }
            })
            .then(responseJSON => {
                imgLinkElement.value = responseJSON.fullFileUrl;
                btShowFileUploadElement.classList.remove("hiddenElm");
                fieldsetElement.classList.add("hiddenElm");
            })
            .catch(error => {
                window.alert(`Image uploading failed. ${error}.`);
            });
    } else {
        window.alert("Please, choose an image file.");
    }


}



function processArtEditFrmData(event,articleId,offset, totalCount, serverUrl,met) {
    event.preventDefault();


    const articleData = {
        title: document.getElementById("title").value.trim(),
        content: document.getElementById("content").value.trim(),
        author: document.getElementById("author").value.trim(),

        imageLink: document.getElementById("imageLink").value.trim(),
        tags: document.getElementById("tags").value.trim()
    };

    if (!(articleData.title && articleData.content)) {
        window.alert("Please, enter article title and content");
        return;
    }

    if (!articleData.author) {
        articleData.author = "Anonymous";
    }

    if (!articleData.imageLink) {
        delete articleData.imageLink;
    }

    if (!articleData.tags) {
        delete articleData.tags;
    } else {
        articleData.tags = articleData.tags.split(",");
        articleData.tags = articleData.tags.map(tag => tag.trim());
        articleData.tags = articleData.tags.filter(tag => tag);
        if (articleData.tags.length === 0) {
            delete articleData.tags;
        }
    }


    const postReqSettings =
        {

            method: met,
            headers: {
                'Content-Type': 'application/json;charset=utf-8',
            },
            body: JSON.stringify(articleData)
        };



    if(met === 'PUT') {
        fetch(`${serverUrl}/article/${articleId}`, postReqSettings)
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    return Promise.reject(new Error(`Server answered with ${response.status}: ${response.statusText}.`));
                }
            })
            .then(responseJSON => {
                window.alert("Updated article successfully saved on server");
            })
            .catch(error => {
                window.alert(`Failed to save the updated article on server. ${error}`);

            })
            .finally(() => window.location.hash = `#article/${articleId}/${offset}/${totalCount}`);
    }else if(met === 'POST'){

        fetch(`${serverUrl}/article`, postReqSettings)
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    return Promise.reject(new Error(`Server answered with ${response.status}: ${response.statusText}.`));
                }
            })
            .then(responseJSON => {
                window.alert("New article successfully saved on server");
            })
            .catch(error => {
                window.alert(`Failed to save the new article on server. ${error}`);

            })
            .finally(() => window.location.hash = `#articles/${offset}/${totalCount}`);
    }


}
