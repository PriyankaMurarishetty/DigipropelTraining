window.onload=()=>
//the function called when calculate button is clicked
{
    /*calling a function calculateTip
    which will calculate the tip for the bill*/
    document.querySelector('#calculate').onclick=claculatetip;

} 
function calculateTip()
{
    /*asingiing values of ID:amount,person,service to
    variables for further calculations.*/
    let amount = document.querySelecteor('#amount').value;
    let person =document.querySelector('#persons').value;
    let serive=document.querySelector('#services').value;
    console.log(service);
    /*calculating the tip by multiplying total-bill and type of
    service;then dividing it by number of persons*/
    //fixing the total amount upto 2digits
    let total=(amount*serive)/person;
    total=total.toFixed(2);
    //finally displaying the tip value
    document.querySelector('#total').innerHTML=total;
}