// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var start = 1895;
var currentyear = new Date().getFullYear();
var options = "";
for (var year = start; year <= currentyear; year++) {
  options += "<option>" + year + "</option>";
}
document.getElementById("year").innerHTML = options;

/*
// Autocomplete Genre
$(function () {
  var availableTags = [
    "Action",
    "Adventure",
    "Animation",
    "Biography",
    "Comedy",
    "Crime",
    "Documentary",
    "Drama",
    "Fantasy",
    "History",
    "Horror",
    "Musical",
    "Mistery",
    "Romance",
    "SciFi",
    "Sport",
    "Thriller",
    "War",
    "Western",
  ];
  $("#tags").autocomplete({
    source: availableTags,
  });
});

// Autocomplete countries.
var options = {
  url: "resources/countries.json",

  getValue: "name",

  list: {
    match: {
      enabled: true,
    },
  },

  theme: "square",
};

$("#countries").easyAutocomplete(options);
*/
