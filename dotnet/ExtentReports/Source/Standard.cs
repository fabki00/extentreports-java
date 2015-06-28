﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelevantCodes.ExtentReports.Source
{
    internal class Standard
    {
        public static string GetSource()
        {
            return @"<!DOCTYPE html>
                    <html>
                        <head>
                            <!--
                                ExtentReports Library 2.0 | http://relevantcodes.com/extentreports-for-selenium/ | https://github.com/anshooarora/
                                Copyright (c) 2015, Anshoo Arora (Relevant Codes) | Copyrights licensed under the New BSD License | http://opensource.org/licenses/BSD-3-Clause
                            --> 
                            <meta name='description' content='ReportUnit description' />
                            <meta name='robots' content='noodp, noydir' />
                            <meta name='viewport' content='width=device-width, initial-scale=1' />
                            <link href='http://fonts.googleapis.com/css?family=Nunito:300,400|Source+Sans+Pro:400,600' rel='stylesheet' type='text/css'>
                            <link rel='stylesheet' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>
                            <link href='http://cdn.rawgit.com/noelboss/featherlight/1.0.4/release/featherlight.min.css' type='text/css' rel='stylesheet' />
                            <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.96.1/css/materialize.min.css'>
                            <title>Extent</title>
                            <style>
                                body {
                                    background-color: #f6f7fa;
                                    font-family: Nunito, 'Open Sans', Arial;
                                    font-size: 13px;
                                }
                                pre {
                                    border: 1px solid #ebedef;
                                    border-radius: 4px;
                                    background-color: #f8f9fa;
                                    color: #222 !important;
                                    font-family: Consolas, monospace;
                                    font-size: 13px;
                                    margin: 0;
                                    padding: 7px 10px;
                                    white-space: pre-wrap;
                                }
                                img {
                                    border: 4px solid #f6f7fa;
                                    display: block;
                                    height: auto;
                                    margin-left: 5px;
                                    margin-top: 15px;
                                    width: 50%;
                                }
                                table {
                                    border: 1px solid #ddd;
                                }
                                th, td {
                                    border-bottom: 1px solid #ddd !important;
                                    color: #222 !important;
                                    padding: 10px;
                                }
                                th {
                                    font-family: Nunito;
                                    font-weight: 400 !important;
                                }
                                td {
                                    font-size: 16px;
                                    font-weight: 400;
                                    word-break: break-all;
                                }
                    
                                /* -- [ global structure ] -- */
                                .container {
                                    padding-top: 20px;
                                }
                                .card-panel {
                                    box-shadow: 0 1px 1px 0 rgba(0, 0, 0, 0.16);
                                }
                                .panel-name {
                                    font-family: Nunito;
                                    font-weight: 300;
                                }
                                .panel-lead {
                                    display: block;
                                    font-size: 20px;
                                    margin-top: 45px;
                                    text-align: center;
                                }
                                .chart-o {
                                    text-align: center;
                                }
                                .chart {
                                    height: 100px;
                                    margin: 10px auto 25px;
                                    position: relative;
                                    text-align: center;
                                    width: 100px;
                                }
                                .chart canvas {
                                    position: absolute;
                                    top: 0;
                                    left: 0;
                                }
                                .percent {
                                    display: inline-block;
                                    line-height: 100px;
                                    z-index: 2;
                                }
                                .percent.sign:after {
                                    content: '%';
                                }
                                .chart-o > div {
                                    display: inline-block;
                                }
                                .weight-light {
                                    font-weight: 300;
                                }
                                .weight-normal {
                                    font-weight: 400;
                                }
                                .weight-bold {
                                    font-weight: 600;
                                }
                                .select-wrapper input.select-dropdown, .input-field label {
                                    font-size: 0.9rem;
                                }
                        
                                /* -- [ side-nav ] -- */
                                nav {
                                    box-shadow: none;
                                }
                                nav, nav .nav-wrapper i, nav a.button-collapse, nav a.button-collapse i {
                                    height: 40px;
                                    line-height: 40px;
                                }
                                nav, .side-nav {
                                    background-color: #1a2a42;
                                }
                                .side-nav .active, .side-nav li:hover {
                                    background-color: #293951 !important;
                                }
                                .side-nav a {
                                    color: #b5c0d2 !important;
                                    font-size: 13px !important;
                                }
                                .report-name {
                                    font-weight: 300;
                                    padding-left: 50px;
                                }
                                nav .right {
                                    color: #c8c8c8;
                                    font-weight: 300;
                                    padding-right: 50px;
                                }
            
                                /* -- [ views ] -- */
                                .views > div {
                                    display: none;
                                }
                                .views > div:first-child {
                                    display: block;
                                }
                                .images-view .row, .runinfo-view .row, .system-view .row, .test-list .row {
                                    margin-bottom: 0;
                                }
            
                                    /* -- [ dashboard ] -- */
                                    .chart > div {
                                        text-align: center;
                                    }
                                    .chart-o + span {
                                        display: block;
                                    }
                                    .dashboard-view .card-panel {
                                        height: 285px;
                                        max-height: 285px;
                                        min-height: 285px;
                                    }
                                    .dashboard-view .panel-lead {
                                        margin-top: 80px;
                                    }
                                    .dashboard-view .progress {
                                        margin-top: 100px;
                                    }
            
                                    /* -- [ runinfo, system ] -- */
                                    .runinfo-view .card-panel, .system-view .card-panel {
                                        min-height: 194px;
                                    }
                
                                    /* -- [ media ] -- */
                                    .images-view .card-panel, {
                                        height: 160px;
                                        max-height: 160px;
                                        min-height: 160px;
                                    }
                                    .videos-view .card-panel {
                	                    height: 180px;
                                        max-height: 180px;
                                        min-height: 180px;
                                    }
                                    .images-view img {
                                        cursor: pointer;
                                        margin: 15px auto 0;
                                        max-height: 100px;
                                        max-width: 150px;
                                    }
                                    .panel-object #video {
				                        display: block;
				                        margin: 15px auto 0;
				                        text-align: center;
				                    }
            
                                /* -- [ filters ] -- */
                                .filters {
                                    margin-bottom: -15px;
                                    margin-left: 4px;
                                    margin-top: 40px;
                                }
                                .dropdown-content li > a, .dropdown-content li > span {
                                    font-size: 0.9rem;
                                    padding: 0.5rem 1rem;
                                }

                                /* -- [ main ] -- */
                                .main {
                                    padding-bottom: 100px;
                                }
            
                                /* -- [ test-list ] -- */
                                .test {
                                    border: 1px solid #bbb;
                                    box-shadow: none !important;
                                    color: #222 !important;
                                    cursor: pointer;
                                    margin-bottom: 5px;
                                }
                                .test div, .test span, .test td  {
                                    font-family: 'Source Sans Pro';
                                }
                                .is-expanded {
                                    border: 1px solid #222;
                                }
                                .test-head {
                                    padding: 0 0 35px;
                                }
                                .test-head .label {
                                    font-size: 13px;
                                    text-transform: uppercase;
                                }
                                .test-head .right {
                                    margin-top: 6px;
                                }
                                .test-head .right span {
                                    background-color: #f6f7fa;
                                    padding: 4px 10px;
                                }
                                .test-name {
                                    font-size: 21px;
                                    font-weight: 400;
                                }
                                .test-desc {
                                    color: #444;
                                    font-size: 16px;
                                    font-weight: 400;
                                    margin-bottom: -30px;
                                    padding-top: 45px;
                                }
                                .test-body {
                                    cursor: auto !important;
                                    display: none;
                                    padding-top: 25px;
                                }
                                .test-started-time, .test-ended-time {
                                    border-left: 2px solid;
                                }
                                .test-started-time {
                                    border-left-color: #5fc29d;
                                }
                                .test-ended-time {
                                    border-left-color: #eea236;
                                }
                                .test th:first-child, table td:first-child {
                                    max-width: 100px;
                                    width: 100px;
                                }
                                .test th:nth-child(2), .test td:nth-child(2) {
                                    font-size: 13px;
                                    text-align: left !important;
                                    max-width: 65px;
                                    width: 65px;
                                }
                                td.status {
			                        padding-left: 20px;
			                    }
            
                                /* -- [ status styles ] -- */
                                .status.fail, .fail i {
                                    color: #eb4549;
                                } 
                                .status.fatal, .fatal > i {
                                    color: darkred;
                                }
                                .status.error, .error > i {
                                    color: tomato;
                                } 
                                .status.warning, .warning > i {
                                    color: orange;
                                }
                                .status.pass, .pass > i {
                                    color: #32CD32;
                                }                
                                .status.info, .info > i {
                                    color: #22a1c4;
                                } 
                                .status.skip, .skip > i {
                                    color: #999;
                                } 
            
                                /* -- [ labels ] -- */
                                .label {
                                    border-radius: 2px;
                                    font-size: 15px;
                                    padding: 2px 5px;
                                    text-transform: none;
                                }
                                .label.success, .label.failure, .label.info, .label.warn, .label.pass, .label.fail, .label.warning, .label.fatal, .label.skip, .label.error {
                                    color: #fff;
                                }
                                .label.success, .label.pass {
                                    background-color: #7fbb00 !important;
                                }
                                .label.fatal {
                                    background-color: #d50000 !important;
                                }
                                .label.failure, .label.fail {
                                    background-color: #f44336 !important;
                                }
                                .label.error {
                                    background-color: #ec407a !important;
                                }
                                .label.info {
                                    background-color: #55bad8  !important;
                                }
                                .label.warn, .label.warning {
                                    background-color: #fdba5b  !important;
                                }
                                .label.skip, .label.skipped {
                                    background-color: #2196f3 !important;
                                }
            
                                /* -- [ media queries ] -- */
                                @media all and (max-width: 1400px) {
                                    .container {
                                        width: 80%;
                                    }
                                }
                                @media all and (max-width: 1200px) {
                                    .container {
                                        width: 90%;
                                    }
                                }
                                @media all and (max-width: 992px) {
                                    .test th:first-child, .test td:first-child, .test th:nth-child(2), .test td:nth-child(2) {
                                        max-width: inherit;
                                        width: inherit;
                                    }
                                    test th:nth-child(2) {
                                        text-align: right;
                                    }
                                }
                                @media all and (max-width: 800px) {
                                    .test-head .left, .test-head .right {
                                        float: none !important;
                                    }
                                    .test-head .right {
                                        margin-top: 20px;
                                    }
                                    .test-desc {
                                        padding-top: 20px;
                                    }
                                }
                                @media all and (max-width: 530px) {
                                    .test-head .right span {
                                        display: block;
                                    }
                                }
                            </style>
                            <!--%%CUSTOMCSS%%-->
                        </head>
                        <body>
                            <nav>
                                <ul id='slide-out' class='side-nav'>
                                    <li class='dashboard-view active'><a href='#!'>Dashboard</a></li>
                                    <li class='runinfo-view'><a href='#!'>RunInfo</a></li>
                                    <li class='system-view'><a href='#!'>System</a></li>
                                    <li class='images-view'><a href='#!'>Images</a></li>
                                    <li class='videos-view'><a href='#!'>Videos</a></li>
                                </ul>
                                <a href='#' data-activates='slide-out' class='button-collapse show-on-large'><i class='mdi-navigation-menu'></i></a>
                                <span class='report-name'><!--%%LOGO%%-->Your Report Name<!--%%LOGO%%--> <!--%%HEADLINE%%-->Your Report Summary<!--%%HEADLINE%%--></span>
                                <span class='right'>ExtentReports</span>
                            </nav>
                            <div class='main'>
                                <div class='container'>
                                    <div class='views'>
                                        <div class='dashboard-view'>
                                            <div class='row'>
                                                <div class='col s12 m6 l4'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Tests View</span>
                                                        <div class='chart-o text-centered' id='ts-status-dashboard'></div>
                                                        <span class='weight-light'><span class='t-pass-count weight-normal'></span> test(s) passed</span>
                                                        <span class='weight-light'><span class='t-fail-count weight-normal'></span> test(s) failed, <span class='t-others-count weight-normal'></span> others</span>
                                                    </div>
                                                </div>
                                                <div class='col s12 m6 l4'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Steps View</span>
                                                        <div class='chart-o text-centered' id='step-status-dashboard'></div>
                                                        <span class='weight-light'><span class='s-pass-count weight-normal'></span> step(s) passed</span>
                                                        <span class='weight-light'><span class='s-fail-count weight-normal'></span> step(s) failed, <span class='s-others-count weight-normal'></span> others</span>
                                                    </div>
                                                </div>
                                                <div class='col s12 m12 l4'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Pass Percentage</span>
                                                        <span class='pass-percentage panel-lead'></span>
                                                        <div class='progress'>
                                                                <div class='determinate'></div>
                                                            </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class='runinfo-view'>
                                            <div class='row'>
                                                <div class='col s12 m6 l3'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Started At</span>
                                                        <span class='panel-lead suite-started-time'><!--%%SUITESTARTTIME%%--></span>
                                                    </div>
                                                </div>
                                                <div class='col s12 m6 l3'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Total Tests</span>
                                                        <div class='chart total-tests' data-percent=''>
                                                            <span class='percent'></span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class='col s12 m6 l3'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Tests Passed</span>
                                                        <div class='chart tests-passed' data-percent=''>
                                                            <span class='percent sign'></span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class='col s12 m6 l3'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Tests Failed</span>
                                                        <div class='chart tests-failed' data-percent=''>
                                                            <span class='percent sign'></span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class='row'>
                                                <div class='col s12 m6 l3'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Ended At</span>
                                                        <span class='panel-lead suite-ended-time'><!--%%SUITEENDTIME%%--><!--%%SUITEENDTIME%%--></span>
                                                    </div>
                                                </div>
                                                <div class='col s12 m6 l3'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Total Steps</span>
                                                        <div class='chart total-steps' data-percent=''>
                                                            <span class='percent'></span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class='col s12 m6 l3'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Steps Passed</span>
                                                        <div class='chart steps-passed' data-percent=''>
                                                            <span class='percent sign'></span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class='col s12 m6 l3'>
                                                    <div class='card-panel'>
                                                        <span class='panel-name'>Steps Failed</span>
                                                        <div class='chart steps-failed' data-percent=''>
                                                            <span class='percent sign'></span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class='system-view'>
                                            <div class='row'>
                                                <!--%%SYSTEMINFOVIEW%%-->
                                            </div>
                                        </div>
                                        <div class='videos-view'>
                                            <div class='row'>
                                                <!--%%VIDEOSVIEW%%-->
                                            </div>
                                        </div>
                                        <div class='images-view'>
                                            <div class='row'>
                                                <!--%%IMAGESVIEW%%-->
                                            </div>
                                        </div>
                                    </div>
                                        <div class='filters'>
                                            <div class='row'>
                                            <div class='input-field col l3 m6 s12 tests-toggle'>
                                                <select>
                                                    <option value='0' selected>Choose your option</option>
                                                    <option value='1'>Pass</option>
                                                    <option value='2'>Fatal</option>
                                                    <option value='3'>Fail</option>
                                                    <option value='4'>Error</option>
                                                    <option value='5'>Warning</option>
                                                    <option value='6'>Skipped</option>
                                                    <option value='7'>Unknown</option>
                                                    <option value='8'>Clear Filters</option>
                                                </select>
                                                <label>Filter Tests</label>
                                            </div>
                                            <div class='input-field col s12 m6 l3 find-tests'>
                                                <input id='test-name-filter' type='text' class='validate'>
                                                <label for='test-name-filter'>Find Test(s)</label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='test-list'>
                                        <!--%%TEST%%-->
                                    </div>
                                </div>
                            </div>
                            <script src='https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js'></script> 
                            <script type='text/javascript' src='https://www.google.com/jsapi'></script>
                            <script src='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.96.1/js/materialize.min.js'></script>
                            <script src='https://cdnjs.cloudflare.com/ajax/libs/easy-pie-chart/2.1.4/jquery.easypiechart.min.js'></script>
                            <script src='http://cdn.rawgit.com/noelboss/featherlight/1.0.4/release/featherlight.min.js' type='text/javascript' charset='utf-8'></script>
                            <script>
                                google.load('visualization', '1', {packages:['corechart']});
                                $(document).ready(function() {
                                    $('.button-collapse').sideNav();
                                    $('select').material_select();
                                    var totalTests = $('.test').length;
                                    var passedTests = $('.test.pass').length;
                                    var failedTests = $('.test.fail').length;
                                    var fatalTests = $('.test.fatal').length;
                                    var warningTests = $('.test.warning').length;
                                    var errorTests = $('.test.error').length;
                                    var skippedTests = $('.test.skip').length;
                                    var unknownTests = $('.test.unknown').length;
                                    var totalSteps = $('td.status').length;
                                    var passedSteps = $('td.status.pass').length;
                                    var failedSteps = $('td.status.fail').length;
                                    var fatalSteps = $('td.status.fail').length;
                                    var warningSteps = $('td.status.warning').length;
                                    var errorSteps = $('td.status.error').length;
                                    var infoSteps = $('td.status.info').length;
                                    var skippedSteps = $('td.status.skipped').length;
                                    var unknownSteps = $('td.status.unknown').length;
                                    var passedPercentage = Math.round((passedTests * 100) / (passedTests + failedTests + fatalTests + warningTests + errorTests)) + '%';
                                    $('.t-pass-count').text(passedTests);
                                    $('.t-fail-count').text(failedTests + fatalTests);
                                    $('.t-warning-count').text(warningTests);
                                    $('.t-fatal-count').text(fatalTests);
                                    $('.t-error-count').text(errorTests);
                                    $('.t-skipped-count').text(skippedTests);
                                    $('.s-pass-count').text(passedSteps);
                                    $('.s-fail-count').text(failedSteps);
                                    $('.s-warning-count').text(warningSteps);
                                    $('.s-fatal-count').text(fatalSteps);
                                    $('.s-error-count').text(errorSteps);
                                    $('.s-skipped-count').text(skippedSteps);
                                    $('.t-others-count').text(warningTests + errorTests + skippedTests + unknownTests);
                                    $('.s-others-count').text(warningSteps + errorSteps + skippedSteps + unknownSteps + infoSteps);
                                    $('.dashboard-view .panel-lead').text(passedPercentage);
                                    $('.dashboard-view .determinate').attr('style', 'width:' + passedPercentage);
                                    $('nav li').click(function() {
                                        if (!$(this).hasClass('active')) {
                                            var cls = $(this).prop('class');
                                            $('nav li').removeClass('active');
                                            $(this).addClass('active');
                                            $('.views > div').not('.' + cls).slideUp().parent().children('.' + cls).slideDown();
                                            if (cls == 'runinfo-view') 
                                                showRunInfo();
                                        }
                                        $('.button-collapse').sideNav('hide');
                                    });
                                    $('.test-list .test').click(function(evt) {
                                        if (evt.target.nodeName == 'DIV' || evt.target.nodeName == 'SPAN') {
                                            $(this).toggleClass('is-expanded').find('.test-body').slideToggle(300);
                                        }
                                    });
                                    // charts
                                    function showRunInfo() {
                                        $('.total-tests > .percent').text(totalTests).parent().easyPieChart({ lineWidth: 12,  trackColor: '#f1f2f3', barColor: '#9c27b0', lineCap: 'butt', scaleColor: '#fff', size: 100 });
                                        $('.total-tests').data('easyPieChart').update('100');
                                        $('.tests-passed > .percent').text(Math.round((passedTests / totalTests) * 100)).parent().easyPieChart({ lineWidth: 12,  trackColor: '#f1f2f3', barColor: '#53b657', lineCap: 'butt', scaleColor: '#fff', size: 100 });
                                        $('.tests-passed').data('easyPieChart').update((passedTests / totalTests) * 100);
                                        $('.tests-failed > .percent').text(Math.round((failedTests / totalTests) * 100)).parent().easyPieChart({ lineWidth: 12,  trackColor: '#f1f2f3', barColor: '#f8576c', lineCap: 'butt', scaleColor: '#fff', size: 100 });
                                        $('.tests-failed').data('easyPieChart').update((failedTests / totalTests) * 100);
                                        $('.total-steps > .percent').text(totalSteps).parent().easyPieChart({ lineWidth: 12,  trackColor: '#f1f2f3', barColor: '#1366d7', lineCap: 'butt', scaleColor: '#fff', size: 100 });
                                        $('.total-steps').data('easyPieChart').update('100');
                                        $('.steps-passed > .percent').text(Math.round((passedSteps / totalSteps) * 100)).parent().easyPieChart({ lineWidth: 12,  trackColor: '#f1f2f3', barColor: '#53b657', lineCap: 'butt', scaleColor: '#fff', size: 100 });
                                        $('.steps-passed').data('easyPieChart').update((passedSteps / totalSteps) * 100);
                                        $('.steps-failed > .percent').text(Math.round((failedSteps / totalSteps) * 100)).parent().easyPieChart({ lineWidth: 12,  trackColor: '#f1f2f3', barColor: '#f8576c', lineCap: 'butt', scaleColor: '#fff', size: 100 });
                                        $('.steps-failed').data('easyPieChart').update((failedSteps / totalSteps) * 100);
                                    }
                                    $(document).keypress(function(e) {
                                        if(e.which == 13) {
                                            if ($('#test-name-filter').is(':focus')) {
                                                var txt = $('#test-name-filter').val();
                                                $('.test').hide(0);
                                                $('.test-name, .test-desc').each(function() {
                                                    if ($(this).text().toLowerCase().indexOf(txt) >= 0) {
                                                        $(this).closest('.test').show();
                                                    }
                                                });
                                            }
                                        }
                                    });
                                    $('.tests-toggle li').click(function() {
                                        var opt = $(this).text().toLowerCase();
                                        if (opt != 'choose your option') {
                                            if (opt == 'clear filters') {
                                                resetFilters();
                                            } else {
                                                $('.test').hide(0);
                                                $('.test.' + opt).fadeIn(0);
                                            }
                                        }                                
                                    });
                                    function resetFilters() {
                                        $('.test').show(0);
                                    }
                                    google.setOnLoadCallback(testSetChart);
                                    google.setOnLoadCallback(testsChart);
                                    function testSetChart() {
                                        var data = google.visualization.arrayToDataTable([
                                            ['Test Status', 'Count'],
                                            ['Pass', passedTests],
                                            ['Error', errorTests],
                                            ['Warning', warningTests],
                                            ['Fail', failedTests],
                                            ['Fatal', fatalTests],
                                            ['Skipped', skippedTests]
                                        ]);
                                        var options = {
                                            backgroundColor: { fill:'transparent' },
                                            chartArea: {'width': '92%', 'height': '100%'},
                                            colors: ['#00af00', 'tomato', 'orange', 'red', 'darkred', '#999'],
                                            fontName: 'Roboto',
                                            fontSize: '11',
                                            titleTextStyle: { color: '#1366d7', fontSize: '14' },
                                            pieHole: 0.55,
                                            height: 180,
                                            pieSliceText: 'value', 
                                            width: 220
                                        };
                                        var chart = new google.visualization.PieChart(document.getElementById('ts-status-dashboard'));
                                        chart.draw(data, options);
                                        }
                                    function testsChart() {
                                        var data = google.visualization.arrayToDataTable([
                                            ['Test Status', 'Count'],
                                            ['Pass', passedSteps],
                                            ['Fail', failedSteps],
                                            ['Fatal', fatalSteps],
                                            ['Error', errorSteps],
                                            ['Warning', warningSteps],
                                            ['Info', infoSteps],
                                            ['Skipped', skippedSteps]
                                        ]);
                                        var options = {
                                            backgroundColor: { fill:'transparent' },
                                            chartArea: {'width': '92%', 'height': '100%'},
                                            colors: ['#00af00', 'red', 'darkred', 'tomato', 'orange', 'dodgerblue', '#999'],
                                            fontName: 'Roboto',
                                            fontSize: '11',
                                            titleTextStyle: { color: '#1366d7', fontSize: '14' },
                                            pieHole: 0.55,
                                            height: 180,
                                            pieSliceText: 'value', 
                                            width: 220
                                        };
                                        var chart = new google.visualization.PieChart(document.getElementById('step-status-dashboard'));
                                        chart.draw(data, options);
                                        }
                                });
                            </script>
                            <!--%%CUSTOMSCRIPT%%-->
                        </body>
                    </html>";
        }
    }
}