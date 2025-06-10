let stages = document.getElementById('stages');

fetch('views/stageview.html')
.then(response => response.text())
.then((text)=> {
    stages.innerHTML=text
});