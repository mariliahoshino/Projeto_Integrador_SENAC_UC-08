function FormataTelefone(campo){
    var tmp = campo.value.length;
    
    if(tmp==0)
    campo.value +="+55(";
    if(tmp==3)
    campo.value +="(";
    if(tmp==6)
    campo.value +=")";
    if(tmp==12)
    campo.value +="-";
    if(tmp>=18)
    {
    
        campo.value = "+55(";
        //function myFunction()
        alert("Por favor, preencher corretamente conforme exemplo \n +55(11)98765-4321");
    }
    

}




function validar(form){
  /*
  alert(form.nome.value);
  alert(form.email.value);
  alert(form.telefone.value);
  */
 caixa_erro_nome = document.querySelector('.msg-nome');
 caixa_erro_email = document.querySelector('.msg-email')

  if (document.getElementById('nome').value=="")
  {
    caixa_erro_nome.innerHTML = "Favor preencher seu nome";
   // alert("Nome não informado")
    document.getElementById('nome').focus;
    return false
  }
  if (document.getElementById('email').value=="")
  {
    caixa_erro_email.innerHTML = "Favor preencher seu email"
    //alert("Email não informado")
    
    document.getElementById('email').focus;
    return false
  }

  

  if (document.getElementById('email').value!="")
  {
    validate();
    return false
  }


  alert("Obrigado pelo cadastro");


    
}


/*
function cadastro() {
    /*
    validate();
    break;
    *//*
    alert("Obrigado pelo contato");
    }
*/



function addcarrinho() {
  
  alert("adicionado ao carrinho");
  }


//carrosel

var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) {slideIndex = 1}    
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";  
  }
  for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
}








    function validateEmail(email) {
        const re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        return re.test(email);
      }
      
      function validate() {

        caixa_erro_email = document.querySelector('.msg-email')
        caixa_erro_nome = document.querySelector('.msg-nome');


        const $result = $("#result");
        const email = $("#email").val();
        $result.text("");
      
        if (validateEmail(email)) {
          /*
          $result.text(email + " é válido :)");
          $result.css("color", "green");
          */

          caixa_erro_email.innerHTML = ""
          caixa_erro_nome.innerHTML = ""

          alert("Obrigado pelo cadastro");

        } else {
          $result.text(email + " não é válido :(");
          $result.css("color", "red");


          caixa_erro_email.innerHTML = "Favor preencher seu email"


        }
        return false;
      }
      
      $("#validate").on("click", validate);