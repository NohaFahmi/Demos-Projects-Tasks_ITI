$("#btn").click(function() {
    var item = document.createElement("div");
    var span = document.createElement("span");
    $(span).css( "marginRight", "10px");
    
    var removeBtn = document.createElement('button');
    $(removeBtn).html("X");
    
    $(item).append($(span).html($("#todo").val()));
    $(item).append(removeBtn);
    $('.content').append($(item));
    // $('.content').append('<br>');

    $(removeBtn).click(function() {
        // $(span).remove();
        // $(removeBtn).remove();
        $(this).parent().remove();

    });

});
