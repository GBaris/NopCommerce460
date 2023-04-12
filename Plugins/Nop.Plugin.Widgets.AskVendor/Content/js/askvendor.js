
//$(document).ready(function () {
//  $(document).on("submit", "#ask-vendor-form", function (e) {
//    e.preventDefault();
//    console.log("form submitted");
//    var vendorId = $('#VendorId').val();
//    console.log("vendorId:", vendorId);
//    var productId = $('#ProductId').val();
//    console.log("productId:", productId);
//    var subject = $('#Subject').val();
//    console.log("subject:", subject);
//    var message = $('#Message').val();
//    console.log("message:", message);

//    var data = JSON.stringify({
//      vendorId: vendorId,
//      productId: productId,
//      subject: subject,
//      message: message
//    });

//    $.ajax({
//      url: '/AskVendor/AskQuestion',
//      type: 'POST',
//      dataType: 'json',
//      contentType: 'application/json; charset=utf-8',
//      data: data,
//      success: function (result) {
//        if (result.success) {
//          location.href = '@Url.Action("ProductDetails", "Product", new { productId = Model.Id })';
//        } else {
//          alert(result.message);
//        }
//      },
//      error: function () {
//        alert('@T("Common.Error")');
//      }
//    });
//  });
//});