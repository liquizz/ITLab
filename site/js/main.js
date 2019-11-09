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
	}
}

let sendFeedback = document.getElementById('sendFeedback');

sendFeedback.onclick = function(){
	let xmlhttp = new XMLHttpRequest();

	xmlhttp.onreadyechange = function(){
		if (xmlhttp.readyState == XMLHttpRequest.DONE) {   // XMLHttpRequest.DONE == 4
           if (xmlhttp.status == 200) {
               let d1 = document.querySelector('.fName');
               let d2 = document.querySelector('.fTel');
               let d3 = document.querySelector('.fAsk');
           }
           else if (xmlhttp.status == 400) {
              alert('There was an error 400');
           }
           else {
               alert('something else other than 200 was returned');
           }
        }
	}
}