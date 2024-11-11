function confirmDelete(activityId) {
    const userConfirmed = confirm("Tem certeza de que deseja excluir esta atividade?");

    if (userConfirmed) {
        $.ajax({
            url: '/Collaborator/Delete', 
            type: 'POST',
            data: { id: activityId },
            success: function (response) {
                if (response.success) {
                    const row = document.getElementById(`row-${activityId}`);
                    if (row) row.remove();
                    alert("Atividade excluída com sucesso.");
                } else {
                    alert("Falha ao excluir a atividade.");
                }
            },
            error: function () {
                alert("Ocorreu um erro ao tentar excluir a atividade.");
            }
        });
    }
}