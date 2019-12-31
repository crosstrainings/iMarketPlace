  $(document).ready(function () {
      $('#dt').dataTable({
          'columnDefs': [{
              'targets': [5,6,7], /* column index */
              'orderable': false, /* true or false */
          }]
      });
}); 