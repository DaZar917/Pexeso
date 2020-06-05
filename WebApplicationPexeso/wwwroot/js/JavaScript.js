function validateForm() {
    var x = document.forms["myForm"]["fname"]["fage"]["fcountry"]["fcomment"].value;
    if (x == null || x == "") {
        alert("You must fill in the field");
        return false;
    }
}