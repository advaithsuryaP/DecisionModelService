using DecisionModelService.Core.Entities;

namespace DecisionModelService.Core.Contracts.Repositories;

public interface IDecisionModelRepository
{
    Task<DecisionModelEntity> CreateAsync(DecisionModelEntity decisionModel, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<DecisionModelEntity>> FindAllAsync(Guid id, CancellationToken cancellationToken = default);

    Task<DecisionModelEntity?> FindByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<DecisionModelEntity?> UpdateAsync(DecisionModelEntity decisionModel, CancellationToken cancellationToken = default);

    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
