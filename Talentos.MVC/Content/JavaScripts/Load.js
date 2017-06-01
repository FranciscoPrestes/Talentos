var myVar;

function ShowLoader() {
    document.getElementById("loader").style.display = "block";
    document.getElementById("divLoad").style.display = "block";
    document.getElementById("divBlock").style.display = "block";
}

function showPage() {
    document.getElementById("loader").style.display = "none";
    document.getElementById("divLoad").style.display = "none";
    document.getElementById("divBlock").style.display = "none";
}

function InitLoader() {
    document.getElementById("loader").style.display = "none";
    document.getElementById("divLoad").style.display = "none";
    document.getElementById("divBlock").style.display = "none";
}