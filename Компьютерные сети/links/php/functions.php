<?php
function getRandWord($num, $exists){
	$word_arr = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'];
	$key = '';
	for($i=0; $i<$num; $i++){
		$key .=$word_arr[rand(0,26)];
	};
	if(in_array($key,$exists)) return getRandWord($num, $exists);
	else return $key;
}
?>