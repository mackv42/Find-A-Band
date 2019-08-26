instrumentList = [];
function getInstrumentList() {
    $.ajax({
        type: "GET",
        url: "/Instrument/List",
        success(data) {
            //jquery to populate select list
            console.log(data);
            instrumentList = data;
            var instruments = document.getElementsByClassName("instruments");

            for (var j = 0; j < instruments.length; j++) {
                for (var i = 0; i < data.length; i++) {
                    //genreList.push({ id: data[i].Id, name: data[i].categoryName });

                    instruments[j].innerHTML += "<option value=" + data[i].instrumentId + ">" + data[i].name + "</option>"
                }
            }

            //var arr = instrumentList.filter(x => x.id == id);
            var ins = document.getElementsByClassName("instrument");
            for (let i = 0; i < ins.length; i++) {
                var id = ins[i].innerHTML;
                ins[i].innerHTML = instrumentList.filter(x => x.instrumentId == id)[0].name;

            }
        }
    });
}
getInstrumentList();
