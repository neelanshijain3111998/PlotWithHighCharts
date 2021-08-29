// JavaScript source code
fetch('Test4.json')
    .then(response => response.json())
    .then(data => plotWithHighCharts5(data));



var i = 0;
function FunctionForYear() {

    i = prompt("Enter 0 for 2000, enter 1 for 2001, enter 2 for 2002.....till 19", 0);
    if (i != null) {
        document.getElementById("demo").innerHTML =
            "Analysis for " + i + " business activitiy is:";
        return i;
    }
}

function plotWithHighCharts5(data) {

    i = 1
    var jsonData = data;


    var jsonkey = Object.keys(jsonData);
    var jsonValue = Object.values(jsonData)

    console.log(jsonkey);//jsonkey=[2000,2001,2002]
    console.log(jsonValue);//jsonValue=[{key:value},{key:value}]

    console.log(jsonkey[i])
    var jsonvalue2 = jsonValue[i]  // {key:value }


    var chart = {
        type: 'line'
        , backgroundColor: 'orange'

    };
    var title = {
        text: '4. Grouped aggregation'
    };
    var subtitle = {
        text: '2001'
    };
    var xAxis = {
        categories: Object.keys(jsonvalue2),
        title: {
            text: 'Principal Business Activity'

        },
    };
    var yAxis = {

        min: 0,
        title: {
            text: 'counts'

        },

    };

    var plotOptions = {
        line: {
            dataLabels: {
                enabled: true
            },

        }
    };
    var legend = {
        layout: 'horizontal',

        align: 'right',
        verticalAlign: 'top',
    };

    var credits = {
        enabled: false
    };
    var series = [
        { name: 'Registration', data: Object.values(jsonvalue2) }
    ]
        ;

    var json = {};
    json.chart = chart;
    json.title = title;
    json.subtitle = subtitle;

    json.xAxis = xAxis;
    json.yAxis = yAxis;
    json.series = series;
    json.plotOptions = plotOptions;
    json.legend = legend;
    json.credits = credits;
    $('#container5').highcharts(json);
}