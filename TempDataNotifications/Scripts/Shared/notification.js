var NOTIFICATION_JS = {

    _buildNotificationDiv: function (type, message) {
        var cssClass = "";
        var imageUrl = "";
        var output = "";

        //Get CSS class to apply and image
        if (type == "success") {
            cssClass = "alert alert-success";
            imageUrl = "../../Content/Images/icon-success.png";
        }
        else if (type == "error") {
            cssClass = "alert alert-danger";
            imageUrl = "../../Content/Images/icon-error.png";
        }
        else if (type == "info") {
            cssClass = "alert alert-info";
            imageUrl = "../../Content/Images/icon-info.png";
        }
        else if (type == "warning") {
            cssClass = "alert alert-warning";
            imageUrl = "../../Content/Images/icon-warning.png";
        }
        else {
            cssClass = "alert alert-info";
            imageUrl = "../../Content/Images/icon-info.png";
        }

        output += "<div class=\"";
        output += cssClass;
        output += "\">";
        output += "<img src=\"" + imageUrl + "\" />";
        output += " " + message;
        output += "</div>";
        return output;

    },

    // type = success, info, error, warning
    showFooterNotification: function (type, message) {
        var output = this._buildNotificationDiv(type, message);
        $('#_FooterNotificationArea').append(output);
    },

    clearFooterNotification: function () {
        $('#_FooterNotificationArea').empty();
    },

    // type = success, info, error, warning
    showPageNotification: function (type, message) {
        var output = this._buildNotificationDiv(type, message);
        $('#_PageNotificationArea').append(output);
    },

    clearPageNotification: function () {
        $('#_PageNotificationArea').empty();
    }

}

$(function () {

});