<?php
	require '/php/config.php';
	require '/php/functions.php';
	$db_con = mysql_connect(DBHOST, DBUSER, DBPASS);
	if(!$db_con){
		die('Ошибка соединения: '.mysql_error());
	};
	mysql_select_db(DBNAME);
	$select_query = 'SELECT postfix FROM main';
	$select_result = mysql_query($select_query);
	$links = mysql_fetch_array($select_result);
	if(isset($_GET['l'])){
		$select_query = "SELECT old_link FROM main WHERE postfix='".$_GET['l']."'";
		$select_result = mysql_query($select_query);
		$link = mysql_fetch_array($select_result);
		//print_r($link[0]);
		header('Location:'.$link[0]);
	};
?>
<!DOCTYPE html>
<head>
	<meta charset="utf-8">
	<title>Пример с ссылками</title>
</head>
<body>
	<p>Добавьте новую ссылку!</p>
	<form action="/php/custom_links.php" method="POST">
		<input type="text" name="link">
		<input type="submit" value="Отправить">
	</form>
</body>