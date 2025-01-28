var detailsTab = document.getElementById("detailsTab");

var referralStatus = document.getElementById("referralStatus");
var referYes = document.getElementById("referYes");
var referNo = document.getElementById("referNo");
var referralDate = document.getElementById("referralDate");
var noReferralReason = document.getElementById("noReferralReason");

var notInterestedReason = document.getElementById("notInterestedReason");

detailsTab.onclick = function () {
    openTabPage(`details`, this, `#7fbafa`, `white`);
}
document.getElementById("verificationTab").onclick = function () {
    openTabPage(`verification`, this, `#7fbafa`, `white`);
}
document.getElementById("employmentTab").onclick = function () {
    openTabPage(`employment`, this, `#7fbafa`, `white`);
}

detailsTab.click();

document.getElementById("responded").style.display = "none";
document.getElementById("noResponse").style.display = "none";

dateFormatRead();

function openTabPage(name, element, backgroundColor, color) {
    let tabcontents = document.getElementsByClassName("tabcontent");
    let tablinks = document.getElementsByClassName("tablink");

    // Hide all elements with class="tabcontent" by default
    for (let i = 0; i < tabcontents.length; i++) {
        tabcontents[i].style.display = "none";
    }

    // Remove the background color of all tablinks/buttons
    for (let i = 0; i < tablinks.length; i++) {
        tablinks[i].style.backgroundColor = "";
        tablinks[i].style.color = "white";
    }

    // Show the specific tab content
    document.getElementById(name).style.display = "block";

    // Add the specific color to the button used to open the tab content
    element.style.backgroundColor = backgroundColor;
    element.style.color = color;

    if (name !== "employment") return;
    if (referYes.checked == true) {
        document.getElementById("employmentField").disabled = false;
    }
    else {
        document.getElementById("employmentField").disabled = true;
    }

}

// STATUS OF VERIFICATION

function verificationStatusValue(respond) {
    let responded = document.getElementById("responded");
    let noResponse = document.getElementById("noResponse");

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

function respondedStatus() {
    resetDate(document.getElementById("followup1"));
    resetDate(document.getElementById("followup2"));

    let invalidContact = document.getElementById("invalidContact");
    invalidContact.checked = false;
    invalidContact.value = "";
}

function noResponseStatus() {
    document.getElementById("interested").checked = false;
    referralStatus.disabled = true;
    referYes.checked = false;
    referNo.checked = false;
    referralDate.disabled = true;
    resetDate(referralDate);
    noReferralReason.disabled = true;
    noReferralReason.value = "";

    document.getElementById("notInterested").checked = false;
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

// EMPLOYMENT STATUS

function employmentStatusValue(element) {
    let hired = document.getElementById("hiredDate");
    let submitDocs = document.getElementById("submitDocsDate");
    let forInterview = document.getElementById("interviewDate");
    let notHired = document.getElementById("notHiredReason");

    if (element.id === "hired") {
        hired.disabled = false;
    }
    else {
        hired.disabled = true;
        resetDate(hired);
    }

    if (element.id === "submitDocs") {
        submitDocs.disabled = false;
    }
    else {
        submitDocs.disabled = true;
        resetDate(submitDocs);
    }

    if (element.id === "forInterview") {
        forInterview.disabled = false;
    }
    else {
        forInterview.disabled = true;
        resetDate(forInterview);
    }

    if (element.id === "notHired") {
        notHired.disabled = false;
    }
    else {
        notHired.disabled = true;
        notHired.value = "";
    }
}

function dateFormatRead() {
    let dateFormats = document.getElementsByClassName("dateFormat");
    let year = "";
    let month = "";
    let day = "";

    let monthName = "";
    for (let dateFormat of dateFormats) {
        if (dateFormat.textContent == "") {
            continue;
        }

        year = dateFormat.textContent.slice(0, 4);
        month = dateFormat.textContent.slice(5, 7);
        day = dateFormat.textContent.slice(8, 10);

        switch (month) {
            case "01":
                monthName = "January";
                break;

            case "02":
                monthName = "February";
                break;

            case "03":
                monthName = "March";
                break;

            case "04":
                monthName = "April";
                break;

            case "05":
                monthName = "May";
                break;

            case "06":
                monthName = "June";
                break;

            case "07":
                monthName = "July";
                break;

            case "08":
                monthName = "August";
                break;

            case "09":
                monthName = "September";
                break;

            case "10":
                monthName = "October";
                break;

            case "11":
                monthName = "November";
                break;

            case "12":
                monthName = "December";
                break;

            default:
                monthName = "Month"
                break;
        }

        dateFormat.textContent = `${monthName} ${day}, ${year}`;
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