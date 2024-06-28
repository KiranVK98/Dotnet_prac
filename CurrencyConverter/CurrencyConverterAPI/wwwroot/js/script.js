async function convertCurrency(conversionType) {
    const amount = document.getElementById("amount").value;

    let url = '';

    if(conversionType === 'inrToUsd')
        {
            url = '/CurrencyConverter/convertInrToUsd';
        }
    else {
        url = '/CurrencyConverter/convertUsdToInr';
    }

    try {

    const response = await fetch(url, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ Amount: amount })
    });

    if (response.ok) {
        const data = await response.json();
        console.log(data);
        let resultText = '';
        if (conversionType === 'inrToUsd') {
            resultText = `USD: ${data.ConvertedAmount}`;
        }
        else {
            resultText = `INR : ${data.ConvertedAmount}`;
        }

        document.getElementById("result").innerText = resultText;
    } else {
        document.getElementById("result").innerText = 'Error converting currency';
    }
}
 catch(error) {
    document.getElementById("result").innerText = "Error Creating currency";
 }}
