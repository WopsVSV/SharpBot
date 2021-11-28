// ==UserScript==
// @name         TW Popup
// @namespace    http://tampermonkey.net/
// @version      1.0
// @description  A simple script for Tribal wars to show army and buildings in the popup for allies.
// @author       You
// @match        https://ukc1.tribalwars.co.uk/game.php?village=*&screen=map
// @icon         https://www.google.com/s2/favicons?domain=triburile.ro
// @grant        none
// ==/UserScript==

function httpGet(theUrl) {
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open( "GET", theUrl, false ); // false for synchronous request
    xmlHttp.send( null );
    return xmlHttp.responseText;
}

document.mycache = [];

(function() {
    //'use strict';

    // nowrap tooltip-delayed

    setInterval(myTimer, 100);

    function myTimer() {
        for(var key in TWMap.villages){
            var hoveredVillage = TWMap.villages[key];
            if(hoveredVillage.id === TWMap.popup._currentVillage){
                var v_id = hoveredVillage.id;

                if(document.mycache[v_id] !== 1){
                    var v_ownerid = hoveredVillage.owner;

                    if(v_ownerid == 0)
                        return;

                    var myTribe = TribalWars.getGameData().player.ally;
                    var targetTribe = TWMap.players[v_ownerid].ally;

                    if(myTribe !== targetTribe){
                        console.log("not from tribe");
                        document.mycache[v_id] = 1;
                        return;
                    }

                    getUnits(v_id, v_ownerid);
                    getBuildings(v_id, v_ownerid);


                    document.mycache[v_id] = 1;

                    TWMap.popup.hide();

                    TWMap.popup.el.fadeIn(50);
                }
            }
        }
    }

    function getUnits(id, owner){
        var url = "https://ukc1.tribalwars.co.uk/game.php?screen=ally&mode=members_troops&player_id=" + owner + "&village=" + id;
        var result = httpGet(url);

        var res_html = document.createElement( 'html' );
        res_html.innerHTML = result;

        var dataTable = res_html.getElementsByClassName('vis w100')[0];

        var rows = dataTable.rows;
        var dataRow;
        for(var i = 1; i < rows.length; i++){
            var villageId = rows[i].cells[0].childNodes[1].href.split("id=")[1];
            if(villageId === id){
                dataRow = dataTable.rows[i];
            }
        }

        var tds = dataRow.querySelectorAll('td');

        var units = [];
        for(i = 0; i < tds.length; i++){
            var unit = tds[i].innerHTML.replace('\n', '').replace(/ /g,'');

            if(unit === '?'){
                unit = 0;
            }

            units[i] = unit;
        }

        TWMap.popup._cache[id].units.spear.count.home = units[1];
        TWMap.popup._cache[id].units.sword.count.home = units[2];
        TWMap.popup._cache[id].units.axe.count.home = units[3];
        TWMap.popup._cache[id].units.archer.count.home = units[4];
        TWMap.popup._cache[id].units.spy.count.home = units[5];
        TWMap.popup._cache[id].units.light.count.home = units[6];
        TWMap.popup._cache[id].units.marcher.count.home = units[7];
        TWMap.popup._cache[id].units.heavy.count.home = units[8];
        TWMap.popup._cache[id].units.ram.count.home = units[9];
        TWMap.popup._cache[id].units.catapult.count.home = units[10];
        TWMap.popup._cache[id].units.snob.count.home = units[11];
    }

    function getBuildings(id, owner){
        var url = "https://ukc1.tribalwars.co.uk/game.php?screen=ally&mode=members_buildings&player_id=" + owner + "&village=" + id;
        var result = httpGet(url);

        var res_html = document.createElement( 'html' );
        res_html.innerHTML = result;

        var dataTable = res_html.getElementsByClassName('vis w100')[0];

        var rows = dataTable.rows;
        var dataRow;
        for(var i = 1; i < rows.length; i++){
            var villageId = rows[i].cells[0].childNodes[1].href.split("id=")[1];
            if(villageId === id){
                dataRow = dataTable.rows[i];
            }
        }

        var tds = dataRow.querySelectorAll('td');

        var data = [];
        for(i = 0; i < tds.length; i++){
            var value = tds[i].innerHTML.replace('\n', '').replace(/ /g,'');

            if(value === '?'){
                value = 0;
            }

            data[i] = value;
        }
        if(!TWMap.popup._cache[id].buildings){
            TWMap.popup._cache[id].buildings = {};
        }

        TWMap.popup._cache[id].buildings.main = data[2];
        TWMap.popup._cache[id].buildings.barracks = data[3];
        TWMap.popup._cache[id].buildings.stable = data[4];
        TWMap.popup._cache[id].buildings.garage = data[5];//workshop
        TWMap.popup._cache[id].buildings.snob = data[6];
        TWMap.popup._cache[id].buildings.smith = data[7];
        TWMap.popup._cache[id].buildings.place = data[8];
        TWMap.popup._cache[id].buildings.market = data[9];
        TWMap.popup._cache[id].buildings.wood = data[10];
        TWMap.popup._cache[id].buildings.stone = data[11];
        TWMap.popup._cache[id].buildings.iron = data[12];
        TWMap.popup._cache[id].buildings.farm = data[13];
        TWMap.popup._cache[id].buildings.storage = data[14];
        TWMap.popup._cache[id].buildings.wall = data[15];
    }

})();
