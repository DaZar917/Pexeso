

function processOpnFrmData(event){
    event.preventDefault();
    const inputs = document.getElementById("opnForm").elements;
    const noFname = inputs[0].value.trim();
    const noSname = inputs[1].value.trim();
    const noEmail = inputs[2].value.trim();
    const noImg = inputs[3].value.trim();
    const noMale = inputs[4].checked;
    const noFemale = inputs[5].checked;
    const noMarried =inputs[6].checked;
    const noUnmarried = inputs[7].checked;
    const noEnglish = inputs[8].checked;
    const noSpanish = inputs[9].checked;
    const noGermany = inputs[10].checked;
    const noSlovencina = inputs[11].checked;
    const noUkraine = inputs[12].checked;
    const noComment = inputs[13].value.trim();
    const noFavorite = inputs[14].value.trim();
    const nopWillReturn = inputs[15].checked;


    const newComment =
        {
            firstName: noFname,
            secondName: noSname,
            email: noEmail,
            img: noImg,
            male: noMale,
            female: noFemale,
            married: noMarried,
            unmarried: noUnmarried,
            english: noEnglish,
            spanish: noSpanish,
            germany: noGermany,
            slov: noSlovencina,
            ukr: noUkraine,
            comment: noComment,
            favorite: noFavorite,
            willReturn: nopWillReturn,
            created: new Date()
        };

    comments.push(newComment);
    localStorage.myTreesComments = JSON.stringify(comments);
    commentsElm.innerHTML+=comment2html(newComment);
    myFrmElm.reset();

}



function maleOrFemale(male){
    if (male === true)
        return 'male';
    else return 'female'
}

function marriedStatus(married) {
    if (married === true)
        return 'married';
    else return 'unmarried';
}

function languages(eng,spa,ger,slov,ukr) {
    let language = "";

    if (eng)
        language += " English";

    if (spa)
        language += " Spanish";

    if (ger)
        language += " Germany";

    if (slov)
        language += " Slovencina";

    if (ukr)
        language += " Ukraine";

    if (!eng && !spa && !slov && !ger && !ukr )
        language += "none";

    language+= ";";
    return language;
}

function noimg(img) {
    if (img  === "")
        img += "../images/33578.png";
    return img;
}



function comment2html(comment){
    const commentView ={
        comFirstName: comment.firstName,
        comSecondName: comment.secondName,
        comEmail: comment.email,
        comImg: noimg(comment.img),
        comSex: maleOrFemale(comment.male),
        comStatus: marriedStatus(comment.married),
        comLang: languages(comment.english,comment.spanish,comment.germany,comment.slov,comment.ukr),
        comComment: comment.comment,
        comFavorite: comment.favorite,
        createdDate: (new Date(comment.created)).toDateString(),
        willReturnMessage: comment.willReturn?"I will return to this page.":"Sorry, one visit was enough."
    };

    const template = document.getElementById("mTmplOneOpinion").innerHTML;
    return Mustache.render(template, commentView);


    //šablónové literály (template literals)
    // return `
    // <section class="newComment" style="color: #232323 ; border: white 1px solid; margin: 20px; border-radius: 50px; background: #fffccf; padding: 20px;">
    //    <h3 style="color: red">${comment.firstName} ${comment.secondName} <i style="color: #232323 ">(${(new Date(comment.created)).toDateString()})</i></h3>
    //    <p>Gender: <span>${(maleOrFemale(comment.male))}</span></p>
    //    <p>E-mail: <span>${(maleOrFemale(comment.email))}</p>
    //    <p>Marital status: <span>${(marriedStatus(comment.married))}</span></p>
    //    <p>Languages knowledge: <span>${(languages(comment.english, comment.spanish, comment.germany, comment.slov, comment.ukr))}</span></p>
    //    <p>Favorite city: <span>${comment.favorite}<br><br></span></p>
    //    <p>Comment: <span>${comment.comment}</span>
    //    <p><span>${comment.willReturn ? "I will return to this page." : "Sorry, one visit was enough."}</span></p>
    // </section>`;
    //


}

function commentArray2html(sourceData){

    let htmlWithComments="";

    for(const com of sourceData){
        htmlWithComments += comment2html(com);
    }

    return htmlWithComments;

}







let comments=[];

const commentsElm=document.getElementById("opinionsContainer");


if(localStorage.myTreesComments){
    comments=JSON.parse(localStorage.myTreesComments);
}
commentsElm.innerHTML=commentArray2html(comments);

console.log(comments);

let myFrmElm=document.getElementById("opnForm");

myFrmElm.addEventListener("submit",processOpnFrmData);




