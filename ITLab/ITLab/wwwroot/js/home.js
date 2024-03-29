// Для статистики

let toSt = false;
render_short_news_block('newsBlock');
render_short_course_block('course');

window.addEventListener("scroll", function () {
    let elementTarget = document.getElementById("statistics");
    if (window.scrollY + document.documentElement.clientHeight
        >= elementTarget.offsetTop + elementTarget.offsetHeight / 2
        && !toSt) {
        toSt = true;
        let el = document.getElementById('yCounter');
        counterAnimation(2015, 1500, 65, el);

        el = document.getElementById('prCounter');
        counterAnimation(10, 1500, 1, el);

        el = document.getElementById('pCounter');
        counterAnimation(500, 1500, 10, el);
    }
});

let arrowDown = document.getElementById('arrowDown');
let slideLeft = document.getElementById('slideLeft');
let slideRight = document.getElementById('slideRight');
let sliderWrapper = document.querySelector('.slider-wrapper');
let counter = 3;

slideRight.onclick = function () {
    let elem = document.querySelectorAll('.slider-news');
    if (counter < elem.length) {
        sliderWrapper.style.left = sliderWrapper.offsetLeft - 520 + 'px';
        counter++;
        if (counter == elem.length) {
            slideLeft.style.visibility = 'visible';
            slideRight.style.visibility = 'hidden';
        } else {
            slideRight.style.visibility = 'visible';
        }
        slideLeft.style.visibility = 'visible';
    } else {
        slideRight.style.visibility = 'hidden';
    }
}
slideLeft.onclick = function () {
    if (counter > 3) {
        sliderWrapper.style.left = sliderWrapper.offsetLeft + 520 + 'px';
        counter--;
        console.log(counter);
        if (counter == 3) {
            slideLeft.style.visibility = 'hidden';
            slideRight.style.visibility = 'visible';
        } else {
            slideLeft.style.visibility = 'visible';
        }
    } else {
        slideLeft.style.visibility = 'hidden';
        slideRight.style.visibility = 'visible';
    }
}


let sendFeedback = document.getElementById('sendFeedback');
sendFeedback.onclick = function () {
    let d1 = document.querySelector('.fName').value;
    let d2 = document.querySelector('.fTel').value;
    let d3 = document.querySelector('.fAsk').value;

    //let data = { FullName: d1, Phone: d2, Question: d3 };

    let xmlhttp = new XMLHttpRequest();
    let formData = new FormData();
    xmlhttp.open("POST", "/Landing/FeedBack", true);
    xmlhttp.setRequestHeader('X-Requested-With', 'XMLHttpRequest');
    formData.append("Content-Type", "application/x-www-form-urlencodedl");
    formData.set("FullName", d1);
    formData.set("Phone", d2);
    formData.set("Question", d3);
    xmlhttp.onload = function () {
        alert('Done');
    };

    xmlhttp.send(formData);

    document.querySelector('.fName').value = "";
    document.querySelector('.fTel').value = "";
    document.querySelector('.fAsk').value = "";


    xmlhttp.onreadyechange = function () {
        if (xmlhttp.readyState == XMLHttpRequest.DONE) {
            if (xmlhttp.status == 200) {
                let body = XMLHttpRequest.response;
                body = JSON.parse(body);
                if (body.status) {
                    console.log('nice!');
                } else {

                }
            }
            else if (xmlhttp.status == 400) {
                alert('There was an error 400');
            }
            else {
                alert('something else other than 200 was returned');
            }
        }
    }
};


// Functions for open/close modal window (trial lesson popup)
function openModal() {
    document.getElementById('global-filter').style.display = 'block';
    document.getElementById('modalFB').style.display = 'block';
}
function closeModal() {
    document.getElementById('global-filter').style.display = 'none';
    document.getElementById('modalFB').style.display = 'none';
}

document.getElementById('close-modal').onclick = closeModal;
document.getElementById('global-filter').onclick = closeModal;

// ================================================================


document.getElementById('fb-first-lesson').onclick = function () {
    document.getElementById('modelAlert').style.display = 'flex'; // Show success notification
    document.getElementById('fb-first-lesson').style.display = 'none'; // Hide send button

    let name = document.getElementById('ffb-name').value;
    let phone = document.getElementById('ffb-phone').value;
    let email = document.getElementById('ffb-email').value;
    let age = document.getElementById('ffb-age').value;

    let data = { name: name, phone: phone, email: email, age: age };

    let xmlhttp = new XMLHttpRequest();

    let hname = window.location.hostname

    xmlhttp.open('POST', `http://${hname}:3000`);
    xmlhttp.setRequestHeader('Content-Type', 'application/json');
    xmlhttp.send(JSON.stringify(data));

    xmlhttp.onreadyechange = function () {
        if (xmlhttp.readyState == XMLHttpRequest.DONE) {
            if (xmlhttp.status == 200) {
                let body = XMLHttpRequest.response;
                body = JSON.parse(body);
                if (body.status) {
                    console.log('nice!');
                } else {

                }
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

// id:  same_news_block

