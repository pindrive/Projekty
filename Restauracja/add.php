<?php

    $id_polaczenia = mysqli_connect("localhost", "root", "", "kawiarnia");
                         
    $nr_stolika = $_POST['stolik'];
    $zamowienie = $_POST['zamowienie'];
    $kwota = $_POST['kwota'];

    $query = mysqli_query($id_polaczenia, "INSERT INTO zamowienia (stolik, zamowienie, kwota) VALUES ($nr_stolika, '$zamowienie', $kwota);");
                        
    mysqli_close($id_polaczenia);
?>