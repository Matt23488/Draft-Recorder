var div = $("#divCountdown");

window.setInterval(function (data)
{
	var num = parseInt(data.text());
	num -= 1;
	data.html("<h3>" + num + "</h3>");

	if(num == 0)
	{
		window.location = "/Draft";
	}
},
1000,
div);