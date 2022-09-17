jQuery.validator.addMethod("nonnumeric",
    function (value, element, params) {
        $.validator.messages.nonnumeric =
            jQuery.validator.format("This field cannot contain numeric characters.")
        return value.match(/\d+/g) == null;
    },
    $.validator.messages.nonnumeric
);