	var modal = document.querySelector('.modal');
        var overflow = document.createElement('div');
        var modalBody = document.getElementById("modalBody");
    $('[data-artid]').click(function openWin() {
		overflow.className = "overflow1";

	//document.body.appendChild(overflow);

	modalBody.appendChild(overflow);

	var articleId = $(this).data('artid');
	console.log(articleId);
	var height = modal.offsetHeight;
	modal.style.marginTop = - height / 2 + "px";
	modal.style.top = "120px";
	modal.style.margin = "0 auto";
	$.ajax
            ({
		type: "GET",
                data: {articleId: articleId },
	url: '@Url.Action("PartialAnnotationView", "Editions")',
                success: function (data) {
		$('.modal').html(data);
	$('.modal').show();
}
});
});



    if (!Element.prototype.remove) {
		Element.prototype.remove = function remove() {
			if (this.parentNode) {
				this.parentNode.removeChild(this);
			}
		};
}

    overflow.onclick = function () {
		modal.style.top = "-100%";
	overflow.remove();
	$('.modal').hide();
}