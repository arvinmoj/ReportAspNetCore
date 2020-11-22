"use strict";

$("#date3").MdPersianDateTimePicker({
  targetTextSelector: "#inputDate3",
  monthsToShow: [1, 1]
});
$(document).ready(function () {
  $(".menu").click(function () {
    $(".menu").css("background-color", "#292b2c");
    $("#Panel").toggle();
  });
});