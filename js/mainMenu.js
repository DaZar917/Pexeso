/*
 * Created by Stefan Korecko, 2020
 * Dropdown menu functionality
 */


document.addEventListener("click",
    function(event){
        if(!event.target.matches("#menuCl, #menuTitle")) hideMenu();
    }
);

//--------------------------------------------------------------------------------

function displayOrHideMenu(){
    document.getElementById("menuIts").classList.toggle("mnShow");
}

function hideMenu() {
    let menuClElmCList=document.getElementById("menuIts").classList;
    if(menuClElmCList.contains("mnShow")) menuClElmCList.remove("mnShow");

}






