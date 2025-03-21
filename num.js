let titleH1= document.getElementById("title");
titleH1.style.color= "Blue";
titleH1.style.fontFamily= "Helvetic";

//let numbersDiv = document.getElementById("numbers");
//let numbersHTML="";
//for(i=1; i<=500;i++){
// numbersHTML = numbersHTML +"<h2 class='badge text-bg-warning mr-2'>"+ i + "</h2>";

//numbersDiv.innerHTML =numbersHTML;
function printNumbers(){
 let upto = document.getElementById("upperRange").value
 titleH1.innerText="Numbers from 1 -" + upto;

 let numbersDiv = document.getElementById("numbers");
let numbersHTML="";
for(i=1; i<=upto;i++){
 numbersHTML = numbersHTML +"<h2 class='badge text-bg-warning mr-2'>"+ i + "</h2>";
}
numbersDiv.innerHTML =numbersHTML;
}