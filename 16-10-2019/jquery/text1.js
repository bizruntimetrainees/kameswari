$(document).ready(function(){  
    $("#button").click(function(){  
        $("p").text("Welcome to javatpoint.com!");  
    });  
});

function displayVals() {    
    var singleValues = $( "#single" ).val();    
    $( "p" ).html( "<b>Value:</b> " + singleValues);    
  }    
  $( "select" ).change( displayVals );    
  displayVals(); 

  $(document).ready(function(){    
    $("#h1").mouseleave(function(){    
       $( "div" ).text( "Bye Bye... leaving heading" ).show().fadeOut( 2000 );   
    });    
}); 
 
function displayVals() {  
  var singleValues = $( "#single" ).val();  
  var multipleValues = $( "#multiple" ).val() || [];  
  $( "p" ).html( "<b>Single:</b> " + singleValues +  
    " <b>Multiple:</b> " + multipleValues.join( ", " ) );  
}  
$( "select" ).change( displayVals );  
displayVals();         

$( "body" ).delegate( "p", "click", function() {  
  $(this ).after( "<p>Click me for another paragraph.</p>" );  
});  


  $(document).ready(function(){  
    $("img").load(function(){  
        alert("Image loaded.");  
    });  
});  

$(document).ready(function(){  
  $("button").click(function(){  
      $("div1").text($("form").serialize());  
  });  
});  

