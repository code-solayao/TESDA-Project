﻿// TAB CONTROL

// Get the element with id="defaultOpen" and click on it
document.getElementById("defaultTab").click();

function openTabPage(name, element, color) {
    let tabcontents;
    let tablinks;

    // Hide all elements with class="tabcontent" by default
    tabcontents = document.getElementsByClassName("tabcontent");
    for (let i = 0; i < tabcontents.length; i++) {
        tabcontents[i].style.display = "none";
    }

    // Remove the background color of all tablinks/buttons
    tablinks = document.getElementsByClassName("tablink");
    for (let i = 0; i < tablinks.length; i++) {
        tablinks[i].style.backgroundColor = "";
        tablinks[i].style.color = "white";
    }

    // Show the specific tab content
    document.getElementById(name).style.display = "block";

    // Add the specific color to the button used to open the tab content
    element.style.backgroundColor = color;
    element.style.color = "black";
}

// STATUS OF VERIFICATION

var responded = document.getElementById("responded");
var noResponse = document.getElementById("noResponse");

responded.style.display = "none";
noResponse.style.display = "none";

function verificationStatusValue(respond) {
    if (respond == true) {
        responded.style.display = "block";
        noResponse.style.display = "none";
        respondedStatus();
    }
    else {
        noResponse.style.display = "block";
        responded.style.display = "none";
        noResponseStatus();
    }
}

var interested = document.getElementById("interested");
var referralStatus = document.getElementById("referralStatus");
var referYes = document.getElementById("referYes");
var referNo = document.getElementById("referNo");
var referralDate = document.getElementById("referralDate");
var noReferralReason = document.getElementById("noReferralReason");

var notInterested = document.getElementById("notInterested");
var notInterestedReason = document.getElementById("notInterestedReason");

var followup1 = document.getElementById("followup1");
var followup2 = document.getElementById("followup2");
var invalidContact = document.getElementById("invalidContact");

function respondedStatus() {
    resetDate(followup1);
    resetDate(followup2);
    invalidContact.checked = false;
    invalidContact.value = "";
}

function noResponseStatus() {
    interested.checked = false;
    referralStatus.disabled = true;
    referYes.checked = false;
    referNo.checked = false;
    referralDate.disabled = true;
    resetDate(referralDate);
    noReferralReason.disabled = true;
    noReferralReason.value = "";

    notInterested.checked = false;
    notInterestedReason.disabled = true;
    notInterestedReason.value = "";
}

function isInterested() {
    referralStatus.disabled = false;
    notInterestedReason.disabled = true;
    notInterestedReason.value = "";
}

function isNotInterested() {
    notInterestedReason.disabled = false;
    referralStatus.disabled = true;
    referYes.checked = false;
    referNo.checked = false;
    referralDate.disabled = true;
    resetDate(referralDate);
    noReferralReason.disabled = true;
    noReferralReason.value = "";
}

function canRefer() {
    referralDate.disabled = false;
    noReferralReason.disabled = true;
    noReferralReason.value = "";
}

function notRefer() {
    noReferralReason.disabled = false;
    referralDate.disabled = true;
    resetDate(referralDate);
}

function contactStatus() {
    if (invalidContact.checked == true) {
        invalidContact.value = "Yes";
    }
    else {
        invalidContact.value = "No";
    }
}

function resetDate(element) {
    element.value = "";

    // prevent error on older browsers (eg. IE8)
    if (element.type === "date") {
        // update the input content visually
        element.type = "text";
        element.type = "date";
    }
}