<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link href="src/css/index.css" rel="stylesheet" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Hola de hola</p>
    <h1>Discografia e historia</h1>
        <img src="./src/img/logo-section.png" alt="login" class="logo-megadeth">
        <p class="parrafo">Megadeth is an American heavy metal band from Los Angeles, California. Guitarist Dave Mustaine and bassist David Ellefson formed the band in 1983 shortly after Mustaine's dismissal from Metallica. Along with Metallica, Anthrax, and Slayer, Megadeth is one of the "Big Four" of American thrash metal, responsible for its development and popularization. Their music features complex arrangements and fast rhythm sections, and lyrical themes of death, war, politics, and religion.</p>
        <div class="row">
            <div class="col span-1-of-2 box">
                <p class="parrafo">
                    Peace Sells... but Who's Buying? is the second studio album by American thrash metal band Megadeth, released on September 19, 1986 by Capitol Records. The project was originally handled by Combat Records, resulting in the original mix of the album being co-produced by Randy Burns. Capitol Records then bought the rights to the album and hired another producer named Paul Lani to mix it himself. The recording of the album was difficult for the band, because of the ongoing drug issues the members had at the time. 
                </p>
            </div>
            <div class="col span-1-of-2 box">
                    <img src="./src/img/album (1).jpg" alt="Peace sells" class="disco1">
            </div>
        </div>
        <div class="row">
            <div class="col span-1-of-2 box">
                <p class="parrafo">
                    Rust in Peace is the fourth studio album by the American thrash metal band Megadeth, released on September 24, 1990 by Capitol Records.It has been cited as one of the best thrash metal records of all time by publications such as Decibel and Kerrang!,and listed as one of the 1001 Albums You Must Hear Before You Die. The album was nominated for a Grammy Award for Best Metal Performance at the 33rd Grammy Awards. 
                </p>
            </div>
            <div class="col span-1-of-2 box">
                    <img src="./src/img/album (4).jpg" alt="Peace sells" class="disco1">
            </div>
        </div>
        <div class="row">
            <div class="col span-1-of-2 box">
                <p class="parrafo">
                    So Far, So Good... So What! (stylized as so far, so good... so what !) is the third studio album by the American thrash metal band Megadeth, released on January 19, 1988 by Capitol Records. It is the band's only album recorded with drummer Chuck Behler and guitarist Jeff Young, both of whom were fired immediately after its subsequent tour. So Far, So Good... So What! features music performed at very fast tempos with technical ability; lyrically, frontman and guitarist Dave Mustaine addresses a variety of topics, including nuclear holocaust and freedom of speech.
                </p>
            </div>
            <div class="col span-1-of-2 box">
                    <img src="./src/img/album (3).jpg" alt="Peace sells" class="disco1">
            </div>  
        </div>
        <div class="row">
            <div class="col span-2-of-2 box">
                <section class="section-ciber-army">
                    <p class="ciber-army parrafo">Join to ciber army</p>
                    <p>Welcome to the brand new Megadeth Cyber Army, Megadeth's official fan club. The MCA is a community where you can connect with other fans, access exclusive content, tour pre-sales, contests, interact with band members and much more. We’ve also relaunched with a​ brand new look along with some special merch packages. Join today!</p>
                    <button class="join">JOIN NOW!</button>
                </section>
            </div>
        </div>
        <div class="row">
            <div class="col span-2-of-2 box">
                <section class="section-form">
                    <h1>Comentarios</h1>
                    <form class="formulario" method="post">
                        <div class="content">
                            <label>Nombre</label><br>
                            <input id="nombre" name="nombre" type="text" /> <br>
                            <label>Email</label><br>
                            <input id="email" name="email" type="text" /> <br>
                            <label>Contenido</label><br>
                            <textarea class="contenido" name="comment" cols="30" rows="5" placeholder="Ingresa aqui el mensaje..."></textarea><br>
        
                            <input id="enviar" name="enviar" type="submit" value="Enviar" />
                        </div>
                    </form>
                </section>
            </div>
        </div>

        <div class="row media">
            <div class="col span-1-of-5 box">
                    <p >Megadeth</p>
                    <img src="./src/img/twitter-ico.png" alt="twitter" class="media-icon">
                    <img src="./src/img/face-ico.png" alt="facebook" class="media-icon">
                    <img src="./src/img/insta-ico.png" alt="instagram" class="media-icon">
            </div>
            <div class="col span-1-of-5 box">
                    <p >Dave</p>
                    <img src="./src/img/twitter-ico.png" alt="twitte" class="media-icon">
                    <img src="./src/img/face-ico.png" alt="facebook" class="media-icon">
                    <img src="./src/img/insta-ico.png" alt="instagram" class="media-icon">
            </div>
            <div class="col span-1-of-5 box">
                <p >Kiko</p>
                <img src="./src/img/twitter-ico.png" alt="twitte" class="media-icon">
                <img src="./src/img/face-ico.png" alt="facebook" class="media-icon">
                <img src="./src/img/insta-ico.png" alt="instagram" class="media-icon">
            </div>
            <div class="col span-1-of-5 box">
                <p >David</p>
                <img src="./src/img/twitter-ico.png" alt="twitte" class="media-icon">
                <img src="./src/img/face-ico.png" alt="facebook" class="media-icon">
                <img src="./src/img/insta-ico.png" alt="instagram" class="media-icon">
            </div>
            <div class="col span-1-of-5 box">
                <p >Dirk</p>
                <img src="./src/img/twitter-ico.png" alt="twitte" class="media-icon">
                <img src="./src/img/face-ico.png" alt="facebook" class="media-icon">
                <img src="./src/img/insta-ico.png" alt="instagram" class="media-icon">
            </div>
        </div>

</asp:Content>
