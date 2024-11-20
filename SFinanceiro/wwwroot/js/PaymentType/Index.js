function confirmDelete(activityId) {
    const userConfirmed = confirm("Tem certeza de que deseja excluir este tipo de pagamento?");

    if (userConfirmed) {
        $.ajax({
            url: '/PaymentType/Delete', 
            type: 'POST',
            data: { id: activityId },
            success: function (response) {
                if (response.success) {
                    const row = document.getElementById(`row-${activityId}`);
                    if (row) row.remove();
                    alert("Tipo de pagamento excluída com sucesso.");
                } else {
                    alert("Falha ao excluir o Tipo de pagamento.");
                }
            },
            error: function () {
                alert("Ocorreu um erro ao tentar excluir o Tipo de pagamento.");
            }
        });
    }
}