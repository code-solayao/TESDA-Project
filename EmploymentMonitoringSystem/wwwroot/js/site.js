﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var district = document.getElementById("selectDistrict");
var city = document.getElementById("selectCity");

var optionValue;

districtToCitySelection();

function addOption(text) {
    let option = document.createElement("option");
    option.text = text;

    if (text == "None") {
        option.value = "";
    }

    return option;
}

function setOptionValue(e) {
    optionValue = e.value;
    districtToCitySelection();
}

function districtToCitySelection() {
    let length = city.options.length - 1;
    for (let i = length; i >= 0; i--) {
        city.remove(i);
    }

    switch (optionValue) {
        case "CaMaNaVa":
            city.add(addOption("None"));
            city.add(addOption("Caloocan City"));
            city.add(addOption("Malabon City"));
            city.add(addOption("Navotas City"));
            city.add(addOption("Valenzuela City"));
            break;

        case "Manila":
            city.add(addOption("Manila"));
            break;

        case "MuntiParLasTaPat":
            city.add(addOption("None"));
            city.add(addOption("Las Piñas City"));
            city.add(addOption("Muntinlupa City"));
            city.add(addOption("Parañaque City"));
            city.add(addOption("Pateros City"));
            city.add(addOption("Taguig City"));
            break;

        case "PaMaMariSan":
            city.add(addOption("None"));
            city.add(addOption("Mandaluyong City"));
            city.add(addOption("Marikina City"));
            city.add(addOption("Pasig City"));
            city.add(addOption("San Juan City"));
            break;

        case "Pasay-Makati":
            city.add(addOption("None"));
            city.add(addOption("Makati City"));
            city.add(addOption("Pasay City"));
            break;

        case "Quezon City":
            city.add(addOption("Quezon City"));
            break;

        default:
            city.add(addOption("None"));
            city.add(addOption("Caloocan City"));
            city.add(addOption("Las Piñas City"));
            city.add(addOption("Makati City"));
            city.add(addOption("Malabon City"));
            city.add(addOption("Mandaluyong City"));
            city.add(addOption("Manila"));
            city.add(addOption("Marikina City"));
            city.add(addOption("Muntinlupa City"));
            city.add(addOption("Navotas City"));
            city.add(addOption("Parañaque City"));
            city.add(addOption("Pasay City"));
            city.add(addOption("Pasig City"));
            city.add(addOption("Pateros City"));
            city.add(addOption("Quezon City"));
            city.add(addOption("San Juan City"));
            city.add(addOption("Taguig City"));
            city.add(addOption("Valenzuela City"));
            break;
    }
}