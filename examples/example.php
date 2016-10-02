<?php
$ch = curl_init('https://api.mcuuid.com/json/uuid/notch');
curl_setopt($ch, CURLOPT_VERBOSE, true);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);
$res = curl_exec($ch);

if (!$res) {
    die('Could not connect.');
}

$json = json_decode($res);
echo $json->uuid; //069a79f4-44e9-4726-a5be-fca90e38aaf5
