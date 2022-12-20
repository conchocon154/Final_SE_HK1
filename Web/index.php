<!DOCTYPE html>
<html lang="vi">

  <head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>DangTan Homepage</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="css/shop-homepage.css" rel="stylesheet">

  </head>

  <body>

    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
      <div class="container">
        <a class="navbar-brand" href=""><img height="50"src="./logo/kshop.png"></img>DANGTAN SHOP</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
          <ul class="navbar-nav ml-auto">
            <li class="nav-item active">
              <a class="nav-link" href="">Home
                <span class="sr-only">(current)</span>
              </a>
            </li>
              <li class="nav-item">
                  <a class="nav-link" href="./controllers/login.php">Login</a>
              </li>
            <li class="nav-item">
              <a class="nav-link" href="./controllers/login.php">Cart (0 items)</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>

    <!-- Page Content -->
    <div class="container">

      <div class="row">

        <div class="col-lg-3">

          <h1 class="my-4">DangTan Shop</h1>

        </div>
        <!-- /.col-lg-3 -->

        <div class="col-lg-9">

          <div id="carouselExampleIndicators" class="carousel slide my-4" style="background-color:#eee;" data-ride="carousel">
            <ol class="carousel-indicators">
              <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
              <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
              <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
            </ol>
            <!-- <div class="carousel-inner" role="listbox">
              <div class="carousel-item active text-center align-center">
                <img class="d-inline img-fluid" src="./images/" alt="First slide">
              </div>
              <div class="carousel-item text-center align-center">
                <img class="d-inline img-fluid" src="./images/" alt="Second slide">
              </div>
              <div class="carousel-item text-center align-center">
                <img class="d-inline img-fluid" src="./images/" alt="Third slide">
              </div>
            </div> -->
            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
              <span class="carousel-control-prev-icon" aria-hidden="true"></span>
              <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
              <span class="carousel-control-next-icon" aria-hidden="true"></span>
              <span class="sr-only">Next</span>
            </a>
          </div>

          <div class="row" id="product">
            <?php
              require_once("./api/connection.php");
              $sql = "SELECT * from product;";
              try{
                  $stmt = $conn->prepare($sql);
                  $stmt->execute();
              }
              catch(PDOException $ex){
                  die(json_encode(array('status' => false, 'data' => $ex->getMessage())));
              }
              $data = array();
              while ($r = $stmt->fetch(PDO::FETCH_ASSOC))
              {
                  $data[] = ["prodid"=>$r["prodid"],"name" => $r["prodname"], "quantity" => $r["quantity"], "price" => $r["price"]];
              }
              foreach($data as $key => $i){
                $id = $i["prodid"];
                $name = $i["name"];
                $price = $i["price"];
                $quantity = $i["quantity"];
                echo "<div class='col-lg-4 col-md-6 mb-4'>
                  <div class='card h-100'>
                    <div class='card-body'>
                      <h4 class='card-title'>
                      <a href='#product'>$name</a>
                      </h4>
                      <h5 style='color: #f47442'>Price: $price</h5>
                      <h5 style='color: #f47442'>Quantity: $quantity</h5>
                    </div>
                    <div class='card-footer'>
                      <button id='$id' onclick='addToCard($id)'' type='button' class='btn btn-primary'>Add to cart</button>
                    </div>
                  </div> 
                </div>";
              }
              ?>
  
            </div>
          <!-- /.row -->

        </div>
        <!-- /.col-lg-9 -->

      </div>
      <!-- /.row -->

    </div>
    <!-- /.container -->

    <!-- Footer -->
    <footer class="py-5 bg-dark">
      <div class="container">
        <p class="m-0 text-center text-white">Copyright &copy; Dang Tan 2022</p>
      </div>
      <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="./js/index.js"></script>
  </body>

</html>
