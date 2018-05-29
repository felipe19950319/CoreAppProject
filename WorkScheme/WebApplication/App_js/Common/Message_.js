/*
Felipe pasache 2018-05-23
----------------------------------------------------------------------------------------------------------------------
Modulo js para generar mensajes e interactuar con el web service para generar una transaccionabilidad en segundo plano
*/

var Message = {};
var Parameter = [];

var SqlConnector = {

    MySql: function () {
        //my sql
        Message.sql = "mySql";
        console.log(Message);
        return this;
    },
    MsSql: function () {
        //sql server
        Message.sql = "msSql";
        console.log(Message);
        return this;
    },
    AddProcedure: function (x) {
        Message.Procedure = x;
        console.log(Message);
        return this;
    },
    AddParameter: function (key, value) {
        Parameter.push({ "key": key, "value": value });
        Message.Parameters = Parameter;
        console.log(Message);
        return this;
    },
    exec: function () {
    }
}

var MessageBus_ = {


}

/*

        var bhRequest = "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
            "<s:Body>" +
            "<GetData xmlns=\"http://tempuri.org/\">" +
            "<value>10</value>" +
            "</GetData>" +
            "</s:Body>" +
        "</s:Envelope>";

            $.ajax({
                type: "POST",
                url: "http://localhost:53084/Service1.svc/GetData",
                data: bhRequest,
                timeout: 10000,
                contentType: "text/xml",
                dataType: "xml",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader("SOAPAction", "http://tempuri.org/IService1/GetData");
                },
                success: function (data) {
                    $(data).find("GetDataResponse").each(function () {
                        alert($(this).find("GetDataResult").text());
                    });
                },
                error: function (xhr, status, error) {
                    alert(error);

                }
            });

*/