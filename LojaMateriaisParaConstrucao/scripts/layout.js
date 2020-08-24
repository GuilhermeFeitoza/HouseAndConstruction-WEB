window.onscroll = function (RolaPagina) {
    var top = window.pageYOffset || document.documentElement.scrollTop
    if (top > 300) {
        console.log('Maior que 300');
    }
}