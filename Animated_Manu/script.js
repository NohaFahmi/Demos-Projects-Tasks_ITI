$('h4').click(function() {
    
    $(this).siblings().slideToggle( "slow");
});

$('.menu').hover(function() {
    $('.menu').animate({marginLeft: "0px"})
},
function() {
    $('.menu').animate({marginLeft: "-220px"})

});