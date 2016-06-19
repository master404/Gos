<?
require 'config.php';
require 'functions.php';

$db_con = mysql_connect(DBHOST, DBUSER, DBPASS);
if(!$db_con){
	die('Ошибка соединения: '.mysql_error());
};
mysql_select_db(DBNAME);
$select_query = 'SELECT postfix FROM main';
$select_result = mysql_query($select_query);
$exists = mysql_fetch_array($select_result);

$old_link = $_POST['link'];
$postfix = getRandWord(5,$exists);
$new_link = "http://".DOMEN."/".$postfix;
$get_query = 'SELECT * FROM main';
$insert_query = "INSERT INTO main (old_link, new_link, postfix) VALUES ('$old_link', '$new_link', '$postfix')";
$insert_result = mysql_query($insert_query);
$fh = fopen(".htaccess", "a"); //Открываем файл .htaccess с дозаписью на последний байт
fwrite($fh, "
RewriteRule ^$postfix$ /a/$postfix.php"); //Записываем ссылку на файл в каталоге a и её сокращённый вариант, который был дан пользователю. !ВНИМАНИЕ! Перенос сделан специально, иначе всё будет писаться в плотную и вызовет 500 ошибку!
fclose($fh); //Закрываем файл
echo "Ссылка добавлена, теперь она выглядит так <a href='$new_link'>$new_link</a>";
?>