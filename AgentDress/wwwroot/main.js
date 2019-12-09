(function(){


    fetch('https://localhost:44374/weatherforecast').then(function(response) {
        console.log(response);
    }).catch(function(reason) {
        console.log(reason);
    })

    // function createHttpRequest(URL, onGetResponse, method) {
    //     var xhr = new XMLHttpRequest();
    //     xhr.open(method, URL, true);
    //     xhr.onreadystatechange = function() {
    //         onGetResponse(xhr);
    //     }
    //     xhr.send(null);
    // }

    // function createSendHttpRequest(URL, onGetResponse, method, send) {
    //     var xhr = new XMLHttpRequest();
    //     xhr.open(method, URL, true);
    //     xhr.onreadystatechange = function() {
    //         onGetResponse(xhr);
    //     }
    //     xhr.setRequestHeader('Content-type', 'application/json')
    //     xhr.send(send);
    // }

    // function onGetData(xhr) {
    //     if (xhr.readyState === 4) {
    //         if (xhr.status === 200) {
    //             var data = JSON.parse(xhr.responseText);
    //             if (Array.isArray(data)) {
    //                 if (data.length > 0) {
    //                     console.log(data);
    //                     // data.forEach(function(item, index, array) {
    //                     //     var passwordBin = item.password;
    //                     //     item.password = binArrayToString(passwordBin);
    //                     // });
    //                 } else {
    //                     alert('Nothing found on your request!');
    //                 }
    //             } else {
    //                 var passwordBin = data.password;
    //                 data.password = binArrayToString(passwordBin);
    //             }
    //         } else {
    //             console.log(xhr.status + ': ' + xhr.statusText);
    //         }
    //     }
    // }
})();