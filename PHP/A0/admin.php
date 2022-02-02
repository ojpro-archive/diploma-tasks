<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body{
            text-align: center
        }
    </style>
</head>
<body>
    <?php
if (isset($_POST["submit"])){
    if(empty($_POST['name']) || empty($_POST['password'])){
        echo "<span class='msg error'>les chomp est vide!</span>";
        
    }else if($_POST["password"] != "mot"){
        echo "<span class='msg error'>Votre Mote de pass non valid!!</span>";
        
    }else{
        echo "<span class='msg error'>Bon jour monsieur ".$_POST["name"]."</span>";
    }
}
?>

    <form action="index.php">
        <button type="submit">Back</button>
    </form>
</body>
</html>