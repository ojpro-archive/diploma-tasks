
<?php
include "./include/header.php";

    if(isset($_GET["vendeur"]) && isset($_GET["produit"]) && $_GET["nombre_commandes"]){
        echo "<p>vous avez commande "
                .$_GET["nombre_commandes"]." 
                ".$_GET["produit"]
                ." aupres du vendeur M. ".
                $_GET["vendeur"].
            ".</p> 
            
    ";
    }else{
        echo "<p class='bg-red-400 p-2 rounded'>un champ ou plus  est vide.</p>";
    }

?>
<form action="index.php">
<button type='submit' name='soumettre' class='bg-blue-400 rounded px-2 py-1 my-1 text-white shadow shadow-blue-500/60'>
                Retour
            </button>
</form>

</body>
</html>
