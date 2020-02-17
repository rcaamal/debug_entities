<?php
$name_error = $email_error = $phone_error = "";
$name = $email = $phone = $phone = $message = "";

if($_SERVER["REQUEST_METHOD"] == "POST"){
	if(empty ($_POST["name"])){
	$name_error = "Name is required";
	}else {
	$name = test_input($_POST["name"]);
	
	if (!preg_match("/^[a-zA-Z]*$/")) {
	$name_error = "Only letters and white space allowed";
	}
	}

	if(empty ($_POST["email"])){
	$email_error = "Email is required";
	}else {
	$email = test_input($_POST["email"]);
	if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
	$email_error = "Invalid email format";
	}
	}


	if(empty ($_POST["phone"])){
	$phone_error = "Phone Number is required";
	}else {
	$phone = test_input($_POST["phone"]);
	if (!preg_match("/^(\d[\s-]?)?[\(\[\s-]{0,2}?\d{3}[\)\]\s-]{0,2}?\d{3}[\s-]?\d{4}$/i",$phone)) {
	$phone_error = "Invalid phone number";
	}	
	}

	if(empty ($_POST["message"])){
	$message = "";
	}else {
	$message = test_input($_POST["message"];
	}
}

function test_input($data){
	$data = trim($data);
	$data = stripslashes($data);
	$data = htmlspecialchars($data);
	return $data;
}