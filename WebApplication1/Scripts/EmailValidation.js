
	var email = document.getElementById("emailField");
	var regex = new RegExp("[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
	var valorCampoEmail = document.forms["login"]["email"].value;
	email.addEventListener('invalid', function () {
		if (!regex.test(valorCampoEmail)) {
			email.setCustomValidity("E-mail informado está com o formato errado.");
		}
	}, false);

