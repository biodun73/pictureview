<!DOCTYPE html>

<html>

<head>
  <title>Hello!</title>
</head>
<link rel="stylesheet" href="color2.css" />
<body>
<form method="post" action="" enctype="multipart/form-data">
    <input type="text" name="myname" />
    <input type="file" name="mfile" />
    <input type="submit" name="submit" value="Upload" />
</form>
<?php
include'connection.php';
include'uploadout.php';

    $name = $_POST['myname'];
    $fileName = $_FILES['mfile']['name'];
    $sql = "INSERT INTO uploadpic(photoname,picfile) VALUES('$name','$fileName')";
    $res = $conn->query($sql);

    $target = "myphoto/".basename($_FILES['mfile']['name']);
    if(move_uploaded_file($_FILES['mfile']['tmp_name'],$target)){
        echo"upload was successfull."."<br>";
    }
    else{
        echo"upload was not successfull."."<br>";
    }

?>

</body>
</html>