    function displayVals() {    
  var singleValues = $( "#single" ).val();    
  $( "p" ).html( "<b>Value:</b> " + singleValues);    
}    
$( "select" ).change( displayVals );    
displayVals();    