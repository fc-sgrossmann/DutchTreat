$(document).ready(function () {


	console.log("Hallo Stefan");

	var theForm = $("#theForm");
	theForm.hide();

	var button = $("#buyButton");
	button.on("click", function () {
		console.log("Gekauft");
	});


	var productInfo = $(".product-props li");
	productInfo.on("click", function () {
		console.log("Sie haben auf " + $(this).text());
	});

	var $loginToggle = $("#loginToggle");
	var $popupForm = $(".popup-form");

	$loginToggle.on("click", function () {
		$popupForm.fadeToggle(1000);
	});

});

