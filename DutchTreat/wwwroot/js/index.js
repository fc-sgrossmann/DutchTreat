console.log("Hallo Stefan");

var theForm = document.getElementById("theForm");
theForm.hidden = true;

var button = document.getElementById("buyButton");
button.addEventListener("click", function () {
	console.log("Gekauft");
});


var productInfo = document.getElementsByClassName("product-props");
var listItems = productInfo.item[0].children;


