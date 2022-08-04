function parseCountry(code){
let countryCode = {"*":"All","FR":"France","IT":"Italy","ES":"Spain","TR":"Turkey","DE":"Germany","PL":"Poland","GB":"United Kingdom","RU":"Russia","CZ":"Czech Republic","PT":"Portugal","NL":"Netherlands","BE":"Belgium","MA":"Morocco","PH":"Philippines","US":"United States","RO":"Romania","DZ":"Algeria","NG":"Nigeria","CH":"Switzerland","HU":"Hungary","TH":"Thailand","SE":"Sweden","ID":"Indonesia","IN":"India","UA":"Ukraine","MY":"Malaysia","TN":"Tunisia","SA":"Saudi Arabia","GR":"Greece","CI":"Ivory Coast","AT":"Austria","ZA":"South Africa","KR":"South Korea","CN":"China","RS":"Serbia","JP":"Japan","EG":"Egypt","SK":"Slovakia","SN":"Senegal","DK":"Denmark","FI":"Finland","CM":"Cameroon","IR":"Iran","AR":"Argentina","CA":"Canada","SG":"Singapore","PK":"Pakistan","GH":"Ghana","LB":"Lebanon","IE":"Ireland","AO":"Angola","NO":"Norway","BY":"Belarus","BR":"Brazil","MX":"Mexico","CO":"Colombia","KE":"Kenya","CL":"Chile","KW":"Kuwait","AL":"Albania","VE":"Venezuela","RE":"Reunion","BA":"Bosnia and Herzegovina","IL":"Israel","TW":"Taiwan","SI":"Slovenia","KZ":"Kazakhstan","PE":"Peru","AZ":"Azerbaijan","AE":"United Arab Emirates","CY":"Cyprus","LT":"Lithuania","DO":"Dominican Republic","JO":"Jordan","MD":"Moldova","BJ":"Benin","BG":"Bulgaria","CD":"Democratic Republic of the Congo","HR":"Croatia","LV":"Latvia","HK":"Hong Kong","MZ":"Mozambique","AU":"Australia","LU":"Luxembourg","UG":"Uganda","ML":"Mali","BF":"Burkina Faso","MU":"Mauritius","OM":"Oman","TG":"Togo","QA":"Qatar","MK":"Macedonia","MG":"Madagascar","VN":"Vietnam","GA":"Gabon","EE":"Estonia","IQ":"Iraq","MT":"Malta","BH":"Bahrain","TZ":"Tanzania","EC":"Ecuador","GE":"Georgia","AM":"Armenia","SD":"Sudan","ET":"Ethiopia","MM":"Myanmar","ME":"Montenegro","SY":"Syria","UZ":"Uzbekistan","ZW":"Zimbabwe","DJ":"Djibouti","LK":"Sri Lanka","BD":"Bangladesh","SH":"Saint Helena","BW":"Botswana","CV":"Cape Verde","BO":"Bolivia","YE":"Yemen","RW":"Rwanda","IS":"Iceland","LY":"Libya","NE":"Niger","AD":"Andorra","GM":"Gambia","CG":"Republic of the Congo","ZM":"Zambia","AF":"Afghanistan","NA":"Namibia","MR":"Mauritania","UY":"Uruguay","CR":"Costa Rica","KG":"Kyrgyzstan","PA":"Panama","NP":"Nepal","GN":"Guinea","GP":"Guadeloupe","GQ":"Equatorial Guinea","MQ":"Martinique","SC":"Seychelles","CU":"Cuba","NZ":"New Zealand","GT":"Guatemala","MC":"Monaco","MV":"Maldives","MW":"Malawi","SV":"El Salvador","GF":"French Guiana","SL":"Sierra Leone","LR":"Liberia","NI":"Nicaragua","KH":"Cambodia","TJ":"Tajikistan","PR":"Puerto Rico","BI":"Burundi","PY":"Paraguay","KM":"Comoros","LS":"Lesotho","SO":"Somalia","HN":"Honduras","TD":"Chad","GI":"Gibraltar","BN":"Brunei","SM":"San Marino","JE":"Jersey","SZ":"Swaziland","TM":"Turkmenistan","NC":"New Caledonia","MN":"Mongolia","LI":"Liechtenstein","GL":"Greenland","BT":"Bhutan","PF":"French Polynesia","ST":"Sao Tome and Principe","YT":"Mayotte","FO":"Faroe Islands","JM":"Jamaica","HT":"Haiti","BS":"Bahamas","GW":"Guinea-Bissau","FJ":"Fiji","GG":"Guernsey","LA":"Laos","TL":"East Timor","TT":"Trinidad and Tobago","AG":"Antigua and Barbuda","EH":"Western Sahara","CF":"Central African Republic","PW":"Palau","IM":"Isle of Man","AW":"Aruba","BZ":"Belize","AS":"American Samoa","AI":"Anguilla","MP":"Northern Mariana Islands","BM":"Bermuda","ER":"Eritrea","SR":"Suriname","VG":"British Virgin Islands","VI":"U.S. Virgin Islands","GY":"Guyana","BB":"Barbados","MH":"Marshall Islands","MO":"Macao","PG":"Papua New Guinea","KY":"Cayman Islands","KI":"Kiribati","AN":"Netherlands Antilles","CK":"Cook Islands","GU":"Guam","WF":"Wallis and Futuna","PS":"Palestine","TC":"Turks and Caicos Islands","VU":"Vanuatu","LC":"Saint Lucia","TO":"Tonga","CC":"Cocos Islands","WS":"Samoa","GD":"Grenada","VA":"Vatican","IO":"British Indian Ocean Territory","FM":"Micronesia","NU":"Niue","BL":"Saint Barthelemy","KN":"Saint Kitts and Nevis","PM":"Saint Pierre and Miquelon","FK":"Falkland Islands","AQ":"Antarctica","PN":"Pitcairn","MF":"Saint Martin","TV":"Tuvalu","VC":"Saint Vincent and the Grenadines","DM":"Dominica","SB":"Solomon Islands","TK":"Tokelau","NF":"Norfolk Island","CX":"Christmas Island","NR":"Nauru","SJ":"Svalbard and Jan Mayen","MS":"Montserrat","KP":"North Korea","GS":"South Georgia And Sandwich Isl.","BV":"Bouvet Island"};


    return countryCode[code];
}

function analyzeName(e){
    // e.stopPropagation();
    //console.log(e);
    let elem = document.getElementById('name');
    let nameInput = elem.value; 
        //send an http call
        // XMLHttpRequest(readystate 0)
        // let xhr = new XMLHttpRequest();
        // // Configure your request (readystate 1)
        // xhr.open('GET','https://api.agify.io/?name='+nameInput,true);
        // // Send your Request (readystate 2)
        // xhr.send();

        // // 5 stages in every chr request
        // // 0: Unitialized
        // // 1 : loading (we've successfully found the server, and we've opened the connextion)
        // // 2: loaded
        // // 3: interactive
        // // 4: Complete
        // xhr.onreadystatechange=function(){
        //     if(this.readyState ===4 && this.status ===200){
        //         let response = JSON.parse(this.response);
        //         console.log(response);
        //         document.querySelector('#result-name').innerText = response.name;
        //         document.querySelector('result-age').innerText=response.age;
        //     }
        // }
        //Fetch API (uses promise)
        //fetch('https://api.agify.io/?name='+nameInput).then((response)=>response.json()).then((resBody)=>{
         //   document.querySelector('#result-name').innerText = resBody.name;
        //    document.querySelector('#result-age').innerText=resBody.age;
        //}).catch((err)=>alert(err)); 

        const reqArr = ['https://api.agify.io/?name='+nameInput,'https://api.genderize.io?name='+nameInput,'https://api.nationalize.io?name='+nameInput];
        Promise.all([fetch(reqArr[0]).then((response)=>response.json()),fetch(reqArr[1]).then((response)=>response.json()),fetch(reqArr[2]).then((response)=>response.json())]).then((data)=>{
            console.log(data);
            document.querySelector('#result-name').innerText=data[0].name;
            document.querySelector('#result-age').innerText=data[0].age;
            document.querySelector('#result-gender').innerText=`${data[1].gender} likely-hood: ${prob(data[1].probability)}`;
            document.querySelector('#result-nationality').innerText=`${parseCountry(data[2].country[0].country_id)} likely-hood: ${prob(data[2].country[0].probability)}`;
            localStorage.setItem('name',document.getElementById('name').value);
        })
        function prob(dec){
            return `${Math.round(dec*100)}%`
        }
}