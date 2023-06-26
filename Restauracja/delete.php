<?php
    $id_polaczenia = mysqli_connect("localhost", "root", "", "kawiarnia");

    $nr_stolika = $_POST['stolik_del'];

    mysqli_query($id_polaczenia, "DELETE FROM zamowienia WHERE stolik = $nr_stolika;");

    mysqli_close($id_polaczenia);
?>