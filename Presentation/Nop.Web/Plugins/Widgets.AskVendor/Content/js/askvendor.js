$(function () {
  $('#ask-vendor-form').submit(function (e) {
    e.preventDefault();
    var vendorId = $('#VendorId').val();
    var productId = $('#ProductId').val();
    var subject = $('#Subject').val();
    var message = $('#Message').val();

    var data = JSON.stringify({
      vendorId: vendorId,
      productId: productId,
      subject: subject,
      message: message
    });

    $.ajax({
      url: '/Widgets/AskVendor/AskQuestion',
      type: 'POST',
      dataType: 'json',
      contentType: 'application/json; charset=utf-8',
      data: data,
      success: function (result) {
        if (result.success) {
          location.href = '@Url.Action("ProductDetails", "Product", new { productId = Model.Id })';
        } else {
          alert(result.message);
        }
      },
      error: function () {
        alert('@T("Common.Error")');
      }
    });
  });
});