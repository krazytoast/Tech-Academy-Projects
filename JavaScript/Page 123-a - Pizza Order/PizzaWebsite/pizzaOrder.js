
function getReceipt() {
    var text1 = "";
    var text2 = "";
    var runningTotal = 0;
    var sizeTotal = 0;
    var sizeArray = document.getElementsByClassName("size");

    // for loop to verify selected size
    for (var i =0; i < sizeArray.length; i++) {
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value;
            text1 = text1+selectedSize+"<br>";
        }
    }

    // Passing price to seleted size
    if (selectedSize === "Personal Pizza") {
            sizeTotal = 6;
            text2 = text2+sizeTotal+"<br>";
    } else if (selectedSize === "Medium Pizza") {
            sizeTotal = 10;
            text2 = text2+sizeTotal+"<br>";
    } else if (selectedSize === "Large Pizza") {
            sizeTotal = 14;
            text2 = text2+sizeTotal+"<br>";
    } else if (selectedSize === "Extra Large Pizza") {
            sizeTotal = 16;
            text2 = text2+sizeTotal+"<br>";
    }

    // adding and printing totals
    runningTotal = sizeTotal;
    
    getMeat(runningTotal,text1,text2); // These variables will be passed to each additional function
};

function getMeat(runningTotal,text1,text2) {
        var runningTotal = runningTotal;
        var meatTotal = 0;
        var selectedMeat = [];
        var meatArray = document.getElementsByClassName("meats");

    // for loop verifying which meats are checked/selected and concatenating them to text1
    for (var j =0; j < meatArray.length; j++) {
        if (meatArray[j].checked){
            selectedMeat.push(meatArray[j].value);
            
        }
    }

    // var meatCount is assigned the value of selectedMeat.length so if other meats are added or taken away at later times meatCount will still be accurate
    // if meatCount is greater than 1 then -1 from the meatTotal in order to include one meat topping for free with each pizza order
    var meatCount = selectedMeat.length;
    if (meatCount > 1) {
            meatTotal = (meatCount - 1);
    } else {
            meatTotal = 0;
    }

    // runningTotal and adding meat to total
    runningTotal = (runningTotal + meatTotal);
    for (var j =0; j < selectedMeat.length; j++) {
            text1 = text1+selectedMeat[j]+"<br>";
            if (meatCount <= 1) {
                text2 = text2 + 0 + "<br>";
                meatCount = meatCount - 1;
            } else if (meatCount == 2) {
                text2 = text2 + 1 + "<br>";
                meatCount = meatCount -1;
            } else {
                text2 = text2 + 1 + "<br>";
                meatCount = meatCount - 1;
            }
    }
    
    getVeggies(runningTotal,text1,text2); // Once getMeat is finished it calls getVeggies in order to add the veggies to the total
}

function getVeggies(runningTotal,text1,text2) {
    var veggieTotal = 0;
    var selectedVeggie = [];
    var veggieArray = document.getElementsByClassName("veggie");

    // for loop
    for (var v =0; v < veggieArray.length; v++) {
        if (veggieArray[v].checked){
            selectedVeggie.push(veggieArray[v].value);
            
        }
    }

    // var veggieCount
    // If statement gives one free veggie topping by reducing 1 from total or reducing 1 to 0
    var veggieCount = selectedVeggie.length;
    if (veggieCount > 1) {
            veggieTotal = (veggieCount - 1);
    } else {
            veggieTotal = 0;
    }

    // runningTotal and adding veggie to total
    runningTotal = (runningTotal + veggieTotal);
    for (var v = 0; v < selectedVeggie.length; v++) {
            text1 = text1+selectedVeggie[v]+"<br>";
            if (veggieCount <= 1) {
                text2 = text2 + 0 +"<br>";
                veggieCount = veggieCount - 1;
            } else if (veggieCount == 2) {
                text2 = text2 + 1 + "<br>";
                veggieCount = veggieCount - 1;
            } else {
                text2 = text2 + 1 + "<br>";
                veggieCount = veggieCount - 1;
            }
    }
    
    getCheese(runningTotal,text1,text2);
}

function getCheese(runningTotal,text1,text2) {
    var cheeseTotal = 0;
    var selectCheese = [];
    var cheeseArray = document.getElementsByClassName("cheese");

    // for loop to verify selected size
    for (var c =0; c < cheeseArray.length; c++) {
        if (cheeseArray[c].checked) {
            var selectedCheese = cheeseArray[c].value;
            
        }
        if (selectedCheese === "Extra Cheese") {
                cheeseTotal = 3;
        }
    }

    // adding and printing totals
    text2 = text2+cheeseTotal+"<br>";
    text1 = text1+selectedCheese+"<br>";
    runningTotal = (runningTotal + cheeseTotal);
    
    getSauce(runningTotal,text1,text2);
}

function getSauce(runningTotal,text1,text2) {
    var sauceArray = document.getElementsByClassName("sauce");

    // for loop to verify selected sauce
    for (var s =0; s < sauceArray.length; s++) {
        if (sauceArray[s].checked) {
            var selectedSauce = sauceArray[s].value;
            text1 = text1+selectedSauce+"<br>";
        }
    }

    text2 = text2+ 0 +"<br>";
    
    getCrust(runningTotal,text1,text2);
}

function getCrust(runningTotal,text1,text2) {
    var crustTotal = 0;
    var selectedCrust;
    var crustArray = document.getElementsByClassName("crust");

    // for loop to verify selected crust
    for (var c =0; c < crustArray.length; c++) {
        if (crustArray[c].checked) {
            selectedCrust = crustArray[c].value;
            text1 = text1+selectedCrust+"<br>";
        }
        if (selectedCrust === "Cheese Stuffed Crust") {
			crustTotal = 3;
		}
    }

    // adding and printing totals
    runningTotal = (runningTotal + crustTotal);
    text2 = text2 +crustTotal+"<br>";
    
    document.getElementById("showText1").innerHTML=text1;
    document.getElementById("showText2").innerHTML=text2;
    document.getElementById("totalPrice").innerHTML = "</h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
}

function resetOrder() {
    var resetText = "";
    document.getElementById("frmMenu").reset();
    document.getElementById("showText1").innerHTML=resetText;
    document.getElementById("showText2").innerHTML=resetText;
    document.getElementById("totalPrice").innerHTML=resetText;
}