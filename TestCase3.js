// JavaScript source code

fetch('./Test3.json')
    .then(response => response.json())
    .then(data => plotWithHighCharts3(data));


function plotWithHighCharts3(data) {

    var jsonObj = data;
    console.log(Object.keys(jsonObj));
    console.log(Object.values(jsonObj));


    var chart = {
        type: 'bar'
        ,
        backgroundColor: 'orange'
    };
    var title = {
        text: 'Company Registration by principal business activity (for the year 2015)'
    };
    var subtitle = {
        text: 'null'
    };
    var xAxis = {
        categories: Object.keys(jsonObj),
        title: {
            text: 'PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN'

        },
    };
    var yAxis = {
        min: 0,
        title: {
            text: 'No Of Registrations'

        },

    };

    var plotOptions = {
        bar: {
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
        { name: 'Registration', data: Object.values(jsonObj) }
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
    $('#container3').highcharts(json);
}