new WOW().init();
// Для статистики!!!
let toSt = false;

function counterAnimation(allCount, animationTime, delta, el){
	let counter = 0;
    animationTime /= allCount / delta;
    let t = setInterval(function(){
    	counter += delta;
      	el.textContent = counter;
      	if(counter >= allCount) clearInterval(t);
    }, animationTime);
}

window.addEventListener("scroll", function(){
	let elementTarget = document.getElementById("statistics");
  	if (window.scrollY + document.documentElement.clientHeight
	>= elementTarget.offsetTop + elementTarget.offsetHeight / 2
	&& !toSt){
	    toSt = true;
		let el = document.getElementById('yCounter');
		counterAnimation(2015, 1500, 65, el);

		el = document.getElementById('prCounter');
		counterAnimation(14, 1500, 1, el);

	    el = document.getElementById('pCounter');
		counterAnimation(1000, 1500, 10, el);
	}
});

let arrowDown = document.getElementById('arrowDown');

function toElem(elem){
	elem.scrollIntoView({block: 'start', behavior: 'smooth'});
}

let slideLeft = document.getElementById('slideLeft');
let slideRight = document.getElementById('slideRight');
let sliderWrapper = document.querySelector('.slider-wrapper');
let counter = 3;

slideRight.onclick = function(){
	let elem = document.querySelectorAll('.slider-news');
	if(counter < elem.length){
		sliderWrapper.style.left = sliderWrapper.offsetLeft - 320 + 'px';
		counter++;
		if(counter == elem.length){
			slideLeft.style.visibility = 'visible';
			slideRight.style.visibility = 'hidden';
		}else{
			slideRight.style.visibility = 'visible';
		}
		slideLeft.style.visibility = 'visible';
	}else{
		slideRight.style.visibility = 'hidden';
	}
}
slideLeft.onclick = function(){
	if(counter > 3){
		sliderWrapper.style.left = sliderWrapper.offsetLeft + 320 + 'px';
		counter--;
		console.log(counter);
		if(counter == 3){
			slideLeft.style.visibility = 'hidden';
			slideRight.style.visibility = 'visible';
		}else{
			slideLeft.style.visibility = 'visible';
		}
	}else{
		slideLeft.style.visibility = 'hidden';
		slideRight.style.visibility = 'visible';    
	}
}

let sendFeedback = document.getElementById('sendFeedback');

sendFeedback.onclick = function () {
	let d1 = document.querySelector(".fName").value;
    let d2 = document.querySelector(".fTel").value;
    let d3 = document.querySelector(".fAsk").value;

    let data = {FullName: d1, Phone: d2, Question: d3};
    var myJSON = JSON.stringify(data);
    let request = new XMLHttpRequest();
    let url = "https://localhost:44301/Landing/FeedBack";
  
    request.open("POST", url, true);

    request.setRequestHeader("Content-type", "application/json");
    request.addEventListener("readystatechange", () => {

        if (request.readyState === 4 && request.status === 200) {
            console.log(request.responseText);
        }
    });
    console.log(myJSON)
    request.send(myJSON);
}

function openModal(){
	document.getElementById('global-filter').style.display = 'block';
	document.getElementById('modalFB').style.display = 'block';
}	
function closeModal(){
	document.getElementById('global-filter').style.display = 'none';
	document.getElementById('modalFB').style.display = 'none';
}

document.getElementById('mfb1').onclick = openModal;
document.getElementById('mfb2').onclick = openModal;
document.getElementById('mfb3').onclick = openModal;

document.getElementById('close-modal').onclick = closeModal;


document.getElementById('fb-first-lesson').onclick = function(){
	let name = document.getElementById('ffb-name').value;
	let phone = document.getElementById('ffb-name').value;
	let email = document.getElementById('ffb-name').value;
	let age = document.getElementById('ffb-name').value;

	let data = {name: name, phone: phone, email: email, age: age};

	let xmlhttp = new XMLHttpRequest();

	xmlhttp.open('POST', 'http://localhost:3000');
	xmlhttp.setRequestHeader('Content-Type', 'application/json');
	xmlhttp.send(JSON.stringify(data));

	xmlhttp.onreadyechange = function(){
		if (xmlhttp.readyState == XMLHttpRequest.DONE) {
           if (xmlhttp.status == 200){
           		let body = XMLHttpRequest.response;
           		body = JSON.parse(body);
           		if(body.status){
           			console.log('nice!');
           		}else{

           		}
           }
           else if (xmlhttp.status == 400){
              alert('There was an error 400');
           }
           else {
               alert('something else other than 200 was returned');
           }
        }
	}
}