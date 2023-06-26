<?php

    $id_polaczenia = mysqli_connect("localhost", "root", "", "kawiarnia");

    $query_2 = mysqli_query($id_polaczenia, "SELECT * FROM zamowienia;");

    while ($rows = mysqli_fetch_row($query_2)) 
    {
        echo "
        <section id ='blok_zamowienia'>
            <u> <b> Stolik </b> </u>: $rows[1] <br>
            <u> <b> Zamówienie </b> </u> : $rows[2] <br>
            <u> <b> Kwota </b> </u>: $rows[3] zł <br>
        </section>
        ";
    }

    mysqli_close($id_polaczenia);

?>