<?php 
// include header 
include "./include/header.php";
// include the file that contains the list of products
require_once("./include/list.php");
 ?>

  <!-- Formulaire -->
  <form action="result.php" method="get">
    <span class="my-2">Liste des vendeurs</span>
    <br />
    <select name="vendeur" class="border-2 my-2 rounded" multiple>
      <option class="m-1" value="Martin">M. Martin</option>
      <option class="m-1" value="Dupont">M. Dupont</option>
      <option class="m-1" value="Louis">M. Louis</option>
      <option class="m-1" value="Durand">M. Durand</option>
    </select>
    <br />

    <span class="my-2">Liste des Produits</span>
    <br />
    <select name="produit" class="border-2 my-2 rounded">
        <?php
        foreach($produits as $produit){
            echo "<option class='m-1' name='$produit'>$produit</option>";
        }
        ?>
    </select>
    <br />

    <label for="nombre_commandes">
      Nombre de produits a commander:
      <input type="number" class="border-2 rounded h-6 w-16 pl-1 py-3" name="nombre_commandes" id="nombre_commandes" />
    </label>
    <br />
    <button type="submit" class="bg-blue-400 rounded px-2 py-1 my-1 text-white shadow shadow-black-200/60">Soumettre</button>
</form>
</div>
</body>
</html>