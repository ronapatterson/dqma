$(document).ready(async function () {
    await getUserRole();

    $("#statementUpload").change(async function () {
        await uploadFile();
    });

    $("#gpsBtn").click(async function () {
        await getGPS();
    })
});

async function createStatement() {
    validateInput();
    validateGps();
}

async function uploadFile() {
    try {
        validateInput();

        var data = new FormData();

        var files = $("#statementUpload").get(0).files;

        if (files.length > 0) {
            data.append("UploadedImage", files[0]);
        }

        const response = await fetch('/api/statement/uploadimage', {
            method: 'POST',
            cache: 'no-cache',
            body: data
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        } else {
            let result = await response.json();
            await loadOcrResult(result);
        }
    } catch (e) {
        console.log(e);
    }

    /*$.ajax({
        url: '/api/statement/uploadimage',
        type: 'POST',
        contentType: false,
        processData: false,
        data: data,
        cache: false,
        success: function () {
            window.location.reload(true);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });*/
}

async function loadOcrResult(result) {
    $("#statementPic").attr("src", result.imageUrl);

    document.getElementById('scannedTxt').value = result.narrative;
}

function validateGps() {
    var latitude = document.getElementById("latitudeTxt").value;
    var longitude = document.getElementById("longitudeTxt").value;

    if (latitude == "" || longitude == "") {
        swal("Error", "Gps longitude & latitude are required.", "error");
    }
}

function validateInput() {
    if (document.getElementById("statementUpload").value == "") {
        swal("Error", "Please select an image.", "error");
        return false;
    }
    return true;
};

function loadStatementForm(statement) {

}

function dropdownDefault(select) {
    var opt = "Choose an option";
    var el = document.createElement("option");
    el.textContent = opt;
    el.value = "";
    select.appendChild(el);
}

async function getCategories() {
    try {
        const response = await fetch('/api/statement/category', {
            method: 'GET',
            cache: 'no-cache',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        } else {
            let result = await response.json();
            await loadCategories(result);
        }

    } catch (e) {
        console.log(e);
    }
}

async function loadCategories(categories) {
    var select = document.getElementById("categoryDdl");

    if (select.length === 0) {
        dropdownDefault(select);
        for (var i = 0; i < categories.length; i++) {
            var opt = categories[i];
            var el = document.createElement("option");
            el.textContent = opt.categoryName;
            el.value = opt.id;
            select.appendChild(el);
        };
    };
}

async function getOffense() {
    try {
        const response = await fetch('/api/statement/offense', {
            method: 'GET',
            cache: 'no-cache',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        } else {
            let result = await response.json();
            await loadOffenses(result);
        }

    } catch (e) {
        console.log(e);
    }
}

async function loadOffenses(offenses) {
    var select = document.getElementById("offenseDdl");

    if (select.length === 0) {
        dropdownDefault(select);
        for (var i = 0; i < offenses.length; i++) {
            var opt = offenses[i];
            var el = document.createElement("option");
            el.textContent = opt.offenseName;
            el.value = opt.id;
            select.appendChild(el);
        };
    };
}

async function getDivision() {
    try {
        const response = await fetch('/api/statement/division', {
            method: 'GET',
            cache: 'no-cache',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        } else {
            let result = await response.json();
            await loadDivisions(result);
        }

    } catch (e) {
        console.log(e);
    }
}

async function loadDivisions(divisions) {
    var select = document.getElementById("divisionDdl");

    if (select.length === 0) {
        dropdownDefault(select);
        for (var i = 0; i < divisions.length; i++) {
            var opt = divisions[i];
            var el = document.createElement("option");
            el.textContent = opt.divisionName;
            el.value = opt.id;
            select.appendChild(el);
        };
    }; 
}

async function getParishes() {
    try {
        const response = await fetch('/api/statement/parish', {
            method: 'GET',
            cache: 'no-cache',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        } else {
            let result = await response.json();
            await loadParishes(result);
        }

    } catch (e) {
        console.log(e);
    } 
}

async function loadParishes(parishes) {
    var select = document.getElementById("parishDdl");

    if (select.length === 0) {
        dropdownDefault(select);
        for (var i = 0; i < parishes.length; i++) {
            var opt = parishes[i];
            var el = document.createElement("option");
            el.textContent = opt.parishName;
            el.value = opt.id;
            select.appendChild(el);
        };
    };  
}

async function getMotives() {
    try {
        const response = await fetch('/api/statement/motive', {
            method: 'GET',
            cache: 'no-cache',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        } else {
            let result = await response.json();
            await loadMotives(result);
        }

    } catch (e) {
        console.log(e);
    }    
}

async function loadMotives(motives) {
    var select = document.getElementById("motiveDdl");

    if (select.length === 0) {
        dropdownDefault(select);
        for (var i = 0; i < motives.length; i++) {
            var opt = motives[i];
            var el = document.createElement("option");
            el.textContent = opt.motiveName;
            el.value = opt.id;
            select.appendChild(el);
        };
    };  
}

async function getCountry() {
    try {
        const response = await fetch('/api/statement/country', {
            method: 'GET',
            cache: 'no-cache',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        } else {
            let result = await response.json();
            await loadCountries(result);
        }
    } catch (e) {
        console.log(e);
    }
}

async function loadCountries(countries) {
    var select = document.getElementById("countryDdl");

    if (select.length === 0) {
        dropdownDefault(select);
        for (var i = 0; i < countries.length; i++) {
            var opt = countries[i];
            var el = document.createElement("option");
            el.textContent = opt.countryName;
            el.value = opt.id;
            select.appendChild(el);
        };
    }; 
}

async function getGPS() {
    try {
        var address = document.getElementById('addressTxt').value;
        
        var parish = $("#parishDdl option:selected").text();
        var country = $("#countryDdl option:selected").text();

        var fullAddress = address + ',' + parish + ',' + country;

        $.ajax({
            url: '/api/statement/gps/' + fullAddress,
            type: 'GET',
            contentType: false,
            dataType: 'json',
            data: ({
                address: fullAddress
            }),
            cache: false,
            success: async function (json) {
                await loadGPS(json);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(errorThrown);
            }
        });
    } catch (e) {
        console.log(e);
    }
}

async function loadGPS(gps) {
    document.getElementById('latitudeTxt').value = gps.lat;
    document.getElementById('longitudeTxt').value = gps.lon;
}


