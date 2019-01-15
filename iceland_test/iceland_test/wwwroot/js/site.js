function nextDayMovement() {
    var day = $('#hdfDay').val();

    //increment day
    $('#hdfDay').val(parseInt(day) + 1);

    inventoryProcessor(1);
}

function tonightConcert(e) {
    $('#hdfConcert').val(e);

    inventoryProcessor(0);
}

function inventoryProcessor(dayIncrement) {
    //declare wrapper
    var wrapper = $('#divIndexWrapper');

    //declare json arrays
    var inventoryModel = [];
    var settingsModel = [];
    var CombinedModel = [];

    //settings
    var day = $('#hdfDay').val();
    var concert = $('#hdfConcert').val();

    settingsModel.push(
        {
            DayIncrement: dayIncrement,
            Day: day,
            Concert: concert
        });

    //inventory
    var rowCount = $('#hdfInventoryCount').val();
    for (var i = 0; i < rowCount; i++) {
        var name = $('#divInventoryName_' + i).html();
        var sellIn = $('#divInventorySellIn_' + i).html();
        var quality = $('#divInventoryQuality_' + i).html();
        var status = $('#hdfInventoryStatus_' + i).val();

        inventoryModel.push(
            {
                Name: name,
                SellIn: sellIn,
                Quality: quality,
                Status: status
            });
    }

    //combine results and stringify
    CombinedModel.push(
        {
            Settings: settingsModel,
            Inventory: inventoryModel
        });

    var model = JSON.stringify(CombinedModel);

    //post
    $.ajax({
        type: 'POST',
        url: "/Home/InventoryProcessor",
        contentType: "application/json",
        data: model,
        success: function (response) {
            wrapper.html(response);
        }
    });
}