/*
 * Created by Stefan Korecko, 2020
 * Form processing functionality
 */


function processOpnFrmData(event){
    //1.prevent normal event (form sending) processing
    event.preventDefault();

    //2. Read and adjust data from the form (here we remove white spaces before and after the strings)
    const nopName = document.getElementById("fname").value.trim();
    const noSurname = document.getElementById("sname").value.trim();
    const noEmail = document.getElementById("email").value.trim();
    const noImg = document.getElementById("limg").value.trim();
    const noMale = document.getElementById("Male").checked;
    const noMarried =document.getElementById("Married").checked;
    const noEnglish = document.getElementById("English").checked;
    const noSpanish = document.getElementById("Spanish").checked;
    const noGermany = document.getElementById("Germany").checked;
    const noSlovencina = document.getElementById("Slovencina").checked;
    const noUkraine = document.getElementById("Ukraine").checked;
    const noComment = document.getElementById("comment").value.trim();
    const noFavorite = document.getElementById("FavoriteList").value.trim();

    const nopWillReturn = document.getElementById("willReturnElm").checked;

    //3. Verify the data
    if(nopName===""|| noSurname==="" || noComment==="" || noSurname===""){
        window.alert("Please, enter both your name and opinion");
        return;
    }

    //3. Add the data to the array opinions and local storage
    const newOpinion =
        {
            name: nopName,
            surname: noSurname,
            email: noEmail,
            img: noimg(noImg),

            sex: maleOrFemale(noMale),
            status: marriedStatus(noMarried),
            language: languages(noEnglish,noSpanish,noGermany,noSlovencina,noUkraine),

            comment: noComment,
            favorite: noFavorite,
            willReturn: nopWillReturn,
            created: new Date()

        };


    let opinions = [];
    if(localStorage.myTreesComments){
        opinions=JSON.parse(localStorage.myTreesComments);
    }

    opinions.push(newOpinion);
    localStorage.myTreesComments = JSON.stringify(opinions);

    console.log("New opinion:\n "+JSON.stringify(newOpinion));
    console.log(opinions);

    //5. Go to the opinions
    window.location.hash="#Comments";

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
        img += "images/33578.png";
    return img;
}

