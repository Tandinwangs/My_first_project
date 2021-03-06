*
{
	padding: 0;
	margin: 0;
}
body{
	box-sizing: border-box;
}

.menu{
	background-color: #001a33;
	text-align: center;
	width: 100%;
	position: fixed;

}

.menu ul{
	display: inline-flex;
	list-style: none;
	color: #fff;
}

.menu ul li {
	width: 120px;
	margin: 15px;
	padding: 15px;
}

.menu ul li a{
	text-decoration: none;
	color: #fff;
}

.myFootprint-active, .menu ul li:hover{
	background: darkslategray;
	border-radius: 3px;	
}

.menu .fa{
	margin-right: 8px;
}
 
.sub-menu-1{
	display: none; 
}

.menu ul li:hover .sub-menu-1{
	display: block;
	position: absolute;
	margin-top: 15px;
	margin-right: 15px;
	background: darkcyan;
	perspective: 1000px;
	visibility: visible;
	opacity: 1;
}

.menu ul li:hover .sub-menu-1 ul{
	display: block;
	margin: 5px;
}

.menu ul li:hover .sub-menu-1 ul li{
	width: 70px;
	padding: 10px;
	background: transparent;
	border-radius: 0;
	text-align: left;
	opacity: 1;
	margin-top: 0;
}

.menu ul li:hover .sub-menu-1 ul li a{
	transition: color 0.1s ease-out;
}

.menu ul li:hover .sub-menu-1 ul li a:hover{
	color: black;
	transition: color 0.1s ease-out;
}

 
.sub-menu-2{
	display: none; 
}

.menu ul li:hover .sub-menu-2{
	display: block;
	position: absolute;
	margin-top: 15px;
	margin-right: 15px;
	background: darkcyan;
}

.menu ul li:hover .sub-menu-2 ul{
	display: block;
	margin: 10px;
}

.menu ul li:hover .sub-menu-2 ul li{
	width: 60px;
	padding: 8px;
	background: transparent;
	border-radius: 0;
	text-align: left;
}

.menu ul li:hover .sub-menu-2 ul li a:hover{
	color: black;
}

 
.sub-menu-3{
	display: none; 
}

.menu ul li:hover .sub-menu-3{
	display: block;
	position: absolute;
	margin-top: 15px;
	margin-right: 15px;
	background: darkcyan;
}

.menu ul li:hover .sub-menu-3 ul{
	display: block;
	margin: 10px;
}

.menu ul li:hover .sub-menu-3 ul li{
	width: 115px;
	padding: 10px;
	background: transparent;
	border-radius: 0;
	text-align: left;
}

.menu ul li:hover .sub-menu-3 ul li a:hover{
	color: black;
}

div.fixed {
  position: fixed;
  width: 100%;
  bottom: 1px;
  background-color: #001a33;
} 

.fixed ul{
	display: inline-flex;
	list-style: none;
	text-align: center;
	color: white;
}

.fixed .ex{
	margin-left: 400px;
}

.fixed ul li {
	width: 120px;
	margin: 5px;
	padding: 5px;
}

.fixed ul li a{
	text-decoration: none;
	text-align: center;
	color: #fff;
}

.fixed ul li a:hover{
	color: pink;
}

.fa:hover {
    opacity: 0.7;
}

.fa-facebook {
  background: #3B5998;
  color: white;
  padding: 8px;
  width: 15px;
  text-decoration: none;
  margin: 5px 2px;
}

.fa-google {
  background: #dd4b39;
  color: white;
  padding: 8px;
  width: 15px;
  text-decoration: none;
  margin: 5px 2px;
}

.fa-soundcloud {
  background: #ff5500;
  color: white;
  padding: 8px;
  width:20px;
  text-decoration: none;
  margin: 5px 4px;
}

.fa-youtube {
  background: #bb0000;
  color: white;
  padding: 8px;
  width: 15px;
  text-decoration: none;
  margin: 5px 4px;
}

.fa-snapchat-ghost {
  background: #fffc00;
  color: white;
  text-shadow: -1px 0 black, 0 1px black, 1px 0 black, 0 -1px black;
  padding: 8px;
  width: 15px;
  text-decoration: none;
  margin: 5px 4px;
}

.fa-envelope-o{
  background: red;
  color: white;
  text-shadow: -1px 0 black, 0 2px black, 2px 0 black, 0 -1px black;
  padding: 8px;
  width: 18px;
  text-decoration: none;
  margin: 5px 4px;
}

h3{
	color: black;
	text-align: center;
	margin-top: 80px;
}

p{
	text-align: center;
	font-weight: bold;
}

.fixed .foot{
	margin-left: 200px;
}

img{
	height:300px;
	width:530px;
	margin-left: 35px;
	margin-top: 30px;
}

.paro{
	width: 600px;
	height: 1000px;
	margin-left: 450px;
	padding: 1px;
	float: left;
	border: solid 3px;
	margin-bottom: 90px;
}

.p1{
	font-size: 18px;
	text-align: center;
}

.p2{
	font-size: 16px;
	text-align: left;
}

.p3{
	font-size: 16px;
	text-align: left;
}

h5{
	text-align: center;
	font-size: 18px;
}